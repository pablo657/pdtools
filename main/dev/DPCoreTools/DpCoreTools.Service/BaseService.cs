using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using Microsoft.Extensions.Configuration;

namespace DpCoreTools.Service
{
	public class BaseService
	{
		#region Properties

		public string Environment { get; set; }
		public string Domain { get; set; }
		public string Host { get; set; }
		public string User { get; set; }
		public string Password { get; set; }
		private string CredentialPath { get; set; }
		private string SemillaPath { get; set; }
		public bool UseAmp { get; set; }
		#endregion

		#region Public Methods
		public BaseService()
		{
			var configurationBuilder = new ConfigurationBuilder();
			var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
			configurationBuilder.AddJsonFile(path, false);
			var root = configurationBuilder.Build();
			CredentialPath = root.GetSection("Credenciales").GetSection("CredentialPath").Value;
			SemillaPath = root.GetSection("Credenciales").GetSection("SemillaPath").Value;
			UseAmp = false;
		}

		public string ExecuteCommands(StringBuilder pCommand, string pHeader = null)
		{
			var uriDp = "https://" + this.Host + ":5550/service/mgmt/";
			uriDp += this.UseAmp? "amp/1.0" : "3.0";
			var buffer = GetCommandTemplate(pCommand, pHeader);
			var request = (HttpWebRequest)WebRequest.Create(uriDp);
			request.Headers.Add("Content-Type", "text/xml; charset=\"utf-8\"");
			request.Accept = "text/xml";
			request.Method = WebRequestMethods.Http.Post;
			if (this.UseAmp)
				request.PreAuthenticate = true;
			using (var stream = request.GetRequestStream())
			{
				stream.Write(buffer, 0, buffer.Length);
			}
			request.Credentials = GetCredentials().GetCredential(request.RequestUri, "Basic");
			request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(this.User + ":" + this.Password)));
			string value;
			ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(CustomXCertificateValidation);
			using (var response = (HttpWebResponse)request.GetResponse())
			{
				var responseStream = response.GetResponseStream();
				var responseStreamReader = new StreamReader(responseStream ?? throw new InvalidOperationException("Error al procesar comando"));
				value = responseStreamReader.ReadToEnd();
			}
			return value;
		}
		#endregion

		#region Private Methods
		private string LoadKeyValue()
		{
			var pKey = "Credential";
			var pValue = "DATAPOWER";
			var xmlDom = new XmlDocument();
			try
			{
				xmlDom.Load(CredentialPath);
				var nodelist = xmlDom.SelectNodes("//" + pKey + "[@name = '" + pValue + "']");
				if (nodelist.Count > 0)
				{
					var node = nodelist.Item(0).SelectSingleNode("//Ambiente[@name='" + Environment.ToUpper() + "']");
					var sb = new StringBuilder("<nodo>");
					if (node != null)
					{
						if (node.Attributes["encript"] != null)
							sb.Append("<encript>" + node.Attributes["encript"].Value + "</encript>");
						if (node.Attributes["SeedToDecrypt"] != null)
							sb.Append("<SeedToDecrypt>" + node.Attributes["SeedToDecrypt"].Value + "</SeedToDecrypt>");
						sb.Append(node.InnerXml);
						sb.Append("</nodo>");
					}
					return sb.ToString();
				}
				return "<nodo/>";
			}
			catch (Exception ex)
			{
				return "<nodo/>";
			}
		}

		private string Decrypt(string ciphertext, string password)
		{
			RijndaelManaged rijndaelCipher = null;
			PasswordDeriveBytes secretKey = null;
			byte[] encryptedData = null;
			byte[] salt = null;
			byte[] iv = null;
			try
			{
				rijndaelCipher = new RijndaelManaged();
				encryptedData = Convert.FromBase64String(ciphertext);
				salt = Encoding.ASCII.GetBytes(password.Length.ToString());
				rijndaelCipher.Mode = CipherMode.CBC;
				secretKey = new PasswordDeriveBytes(password, salt);
				iv = secretKey.GetBytes(16);
				using (var memoryStream = new MemoryStream(encryptedData))
				{
					using (var decryptor = rijndaelCipher.CreateDecryptor(secretKey.GetBytes(32), iv))
					{
						using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
						{
							var plainText = new byte[encryptedData.Length];
							var decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);
							var plaintext = Encoding.Unicode.GetString(plainText, 0, decryptedCount);
							return plaintext;
						}
					}
				}
			}
			catch (CryptographicException e)
			{
				throw new Exception("ErrorEnMetodo Decrypt(ciphertext,password) :" + e.Message, e);
			}
			catch (Exception e)
			{
				throw new Exception("ErrorEnMetodo Decrypt(ciphertext,password) :" + e.Message, e);
			}
			finally
			{
				rijndaelCipher = null;
				secretKey = null;
				encryptedData = null;
				salt = null;
				iv = null;
			}
		}

		private NetworkCredential GetCredentials()
		{
			// Levantando nodo para ambiente
			var nodo = LoadKeyValue();
			var xmlDocCred = new XmlDocument();
			xmlDocCred.LoadXml(nodo);
			var passwordValue = string.Empty;
			// Load nodo
			if (xmlDocCred.SelectSingleNode("nodo").HasChildNodes)
			{
				var encript = bool.Parse(xmlDocCred.SelectSingleNode("//encript").InnerText);
				// Busco el usuario
				var userEncrypt = xmlDocCred.SelectSingleNode("//User").InnerText;
				//Busco el password
				var passwordEncrypt = xmlDocCred.SelectSingleNode("//Password").InnerText;

				User = userEncrypt;
				Password = passwordEncrypt;
				// Verif Encript
				if (encript)
				{
					var seed = xmlDocCred.SelectSingleNode("//SeedToDecrypt").InnerText;
					var xmlDocument = new XmlDocument();
					xmlDocument.Load(SemillaPath);
					var keypass = xmlDocument.SelectSingleNode("//Security/Applications/App[@secureNameApp='" + seed + "']/Seed").InnerText;
					User = Decrypt(userEncrypt, keypass);
					Password = Decrypt(passwordEncrypt, keypass);
				}
			}
			return new NetworkCredential(User, Password);
		}

		private static bool CustomXCertificateValidation(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
		{
			return true;
		}

		private byte[] GetCommandTemplate(StringBuilder pCommand, string pHeader = null)
		{
			var pCmd = new StringBuilder();
			pCmd.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
			pCmd.AppendLine("<env:Envelope xmlns:env=\"http://schemas.xmlsoap.org/soap/envelope/\">");
			if(!string.IsNullOrEmpty(pHeader))
				pCmd.AppendLine(pHeader);
			pCmd.AppendLine("<env:Body>");
			pCmd.Append(pCommand);
			pCmd.AppendLine("</env:Body>");
			pCmd.AppendLine("</env:Envelope>");
			var strCmd = pCmd.ToString();
			return Encoding.UTF8.GetBytes(strCmd);
		}
		#endregion
	}
}
