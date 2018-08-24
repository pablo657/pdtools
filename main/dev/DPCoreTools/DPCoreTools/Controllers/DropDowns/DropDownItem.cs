using System.Collections.Generic;

namespace DPCoreTools.Controllers
{
	public class DropDownItem
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public string Id
		{ get; set; }


		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The descripcion.
		/// </value>
		public string Description
		{ get; set; }


		/// <summary>
		/// Gets or sets the group.
		/// </summary>
		/// <value>
		/// The group.
		/// </value>
		public string Group
		{ get; set; }


		/// <summary>
		/// Gets or sets value indicating whether [selected].
		/// </summary>
		/// <value>
		///   <c>true</c> if [selected]; otherwise, <c>false</c>.
		/// </value>
		public bool Selected
		{ get; set; }


		/// <summary>
		/// Initializes a new instance of the <see cref="DropDownItem"/> class.
		/// </summary>
		public DropDownItem()
		{
			Group = string.Empty;
		}


		/// <summary>
		/// Initializes new instance of the <see cref="DropDownItem"/> class.
		/// </summary>
		/// <param name="pDescription">The description.</param>
		public DropDownItem(string pDescription)
		{
			Id = pDescription;
			Description = pDescription;
			Selected = false;
			Group = string.Empty;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="DropDownItem"/> class.
		/// </summary>
		/// <param name="pId">The identifier.</param>
		/// <param name="pDescription">The description.</param>
		public DropDownItem(string pId, string pDescription)
		{
			Id = pId;
			Description = pDescription;
			Selected = false;
			Group = string.Empty;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="DropDownItem"/> class.
		/// </summary>
		/// <param name="pId">The identifier.</param>
		/// <param name="pDescription">The description.</param>
		/// <param name="pSelect">if set to <c>true</c> [selected].</param>
		public DropDownItem(string pId, string pDescription, bool pSelect)
		{
			Id = pId;
			Description = pDescription;
			Selected = pSelect;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="DropDownItem"/> class.
		/// </summary>
		/// <param name="pId">The p identifier.</param>
		/// <param name="pDescription">The p description.</param>
		/// <param name="pGrupo">The p group.</param>
		public DropDownItem(string pId, string pDescription, string pGrupo)
		{
			Id = pId;
			Description = pDescription;
			Selected = false;
			Group = pGrupo;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="DropDownItem"/> class.
		/// </summary>
		/// <param name="pId">The identifier.</param>
		/// <param name="pDescription">The descripcion.</param>
		/// <param name="pGrupo">The grupo.</param>
		/// <param name="pSelect">if set to <c>true</c> [seleccionado].</param>
		public DropDownItem(string pId, string pDescription, string pGrupo, bool pSelect)
		{
			Id = pId;
			Description = pDescription;
			Selected = pSelect;
			Group = pGrupo;
		}


		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return Description;
		}
	}


	/// <summary>
	/// Drop Down Items
	/// </summary>
	public class DropDownItems : List<DropDownItem>
	{
		/// <summary>
		/// Obteners the lista.
		/// </summary>
		/// <returns></returns>
		public static DropDownItems GetList()
		{
			var oList = new DropDownItems { new DropDownItem(string.Empty) };
			return oList;
		}


		/// <summary>
		/// Seleccionars the item.
		/// </summary>
		/// <param name="pId">The identifier.</param>
		public void SelectItem(object pId)
		{
			foreach (var oItem in this)
			{
				if (pId != null && oItem.Id == pId.ToString())
					oItem.Selected = true;
				else
					oItem.Selected = false;
			}
		}
	}
}