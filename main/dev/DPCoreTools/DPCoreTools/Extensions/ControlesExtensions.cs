using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using DPCoreTools.Controllers;

namespace DPCoreTools.UI.Extensions
{
	public static class Controles
	{
		/// <summary>
		/// Renderizars the combo.
		/// </summary>
		/// <param name="pHtml">The HTML.</param>
		/// <param name="pNombre">The nombre.</param>
		/// <param name="pValue">The value.</param>
		/// <param name="pItems">The items.</param>
		/// <param name="pAtributos">The atributos.</param>
		/// <returns></returns>
		public static HtmlString RenderDropDown(this IHtmlHelper pHtml, string pNombre, object pValue, DropDownItems pItems, object pAtributos)
		{
			return RenderDropDown(pHtml, pNombre, pValue, pItems, HtmlHelper.AnonymousObjectToHtmlAttributes(pAtributos));
		}


		/// <summary>
		/// Renderize the dropdown.
		/// </summary>
		/// <param name="pHtml">The HTML.</param>
		/// <param name="pName">The name.</param>
		/// <param name="pValue">The value.</param>
		/// <param name="pItems">The items.</param>
		/// <param name="pAttributes">The styles.</param>
		/// <returns></returns>
		public static HtmlString RenderDropDown(this IHtmlHelper pHtml, string pName, object pValue, DropDownItems pItems, IDictionary<String, object> pAttributes = null)
		{
			var wControl = string.Empty;
			var wAtributos = GetAttributes(pAttributes);
			pItems?.SelectItem(pValue);
			wControl += string.Format("<select id=\"{0}\" name=\"{0}\" {1}>\r\n", pName, wAtributos);
			if (pItems != null)
			{
				var wGroups = from options in pItems where options.Group!= null orderby options.Group descending group options by options.Group  into groups select new { Group = groups.Key };
				if (wGroups.Count() > 2)
				{
					foreach (var wGroup in (from options in wGroups where string.IsNullOrEmpty(options.Group) select options))
					{
						var wItemsGroups = from options in pItems where options.Group == wGroup.Group select options;
						wControl = wItemsGroups.Aggregate(wControl, (current, oItem) => current + string.Format("\t<option value=\"{0}\"{2}>{1}</option>\r\n", oItem.Id,
							oItem.Description, (oItem.Selected ? " selected=\"selected\"" : string.Empty)));
					}
					foreach (var wGroup in (from options in wGroups where !string.IsNullOrEmpty(options.Group) select options))
					{
						if (!string.IsNullOrEmpty(wGroup.Group))
							wControl += string.Format("<optgroup label=\"{0}\">", wGroup.Group);
						var wItemsGroups = from options in pItems where options.Group == wGroup.Group select options;
						wControl = wItemsGroups.Aggregate(wControl, (current, oItem) => current + string.Format("\t<option value=\"{0}\"{2}>{1}</option>\r\n", oItem.Id,
							oItem.Description, (oItem.Selected ? " selected=\"selected\"" : string.Empty)));
						if (!string.IsNullOrEmpty(wGroup.Group))
							wControl += "</optgroup>";
					}
				}
				else
				{
					foreach (var oItem in pItems)
					{
						wControl += string.Format("\t<option value=\"{0}\"{2}>{1}</option>\r\n", oItem.Id, oItem.Description, (oItem.Selected ? " selected=\"selected\"" : string.Empty));
					}
				}
			}
			wControl += "</select>\r\n";
			return new HtmlString(wControl);
		}

		/// <summary>
		/// Get the attributes.
		/// </summary>
		/// <param name="pAttributes">The attributes.</param>
		/// <returns></returns>
		private static string GetAttributes(IDictionary<string, object> pAttributes)
		{
			var wRtn = string.Empty;
			if (pAttributes != null)
				wRtn = pAttributes.Aggregate(wRtn, (current, oAtr) => current + string.Format(" {0} = \"{1}\"", oAtr.Key, oAtr.Value));
			return wRtn;
		}
	}
}
