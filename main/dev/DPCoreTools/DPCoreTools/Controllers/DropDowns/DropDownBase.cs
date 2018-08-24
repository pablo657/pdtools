using System.Collections.Generic;

namespace DPCoreTools.Controllers
{
  public class DropDownBase
  {
    public enum EmptyItem
    {
      None,
      Select_Numeric,
      Select_String,
      All_Numerics,
      All_Strings,
      String_Empty
    }

    public static DropDownItem GetEmptyItem(EmptyItem pEmptyItem)
    {
      var oItemVacio = new DropDownItem { Selected = true };

      if (pEmptyItem == EmptyItem.Select_Numeric || pEmptyItem == EmptyItem.All_Numerics)
        oItemVacio.Id = "-1";
      else
        oItemVacio.Id = string.Empty;
      if (pEmptyItem == EmptyItem.Select_Numeric || pEmptyItem == EmptyItem.Select_String)
        oItemVacio.Description = "-- Seleccione --";
      else
        oItemVacio.Description = "-- Todos --";
      return oItemVacio;
    }

    public static DropDownItems PopulateDropDown<T>(List<T> pList, string pShowProperty, string pPropertyValue, EmptyItem pEmptyItem)
    {
      return PopulateDropDown<T>(pList, pShowProperty, pPropertyValue, string.Empty, pEmptyItem);
    }

    public static DropDownItems PopulateDropDown<T>(List<T> pList, string pShowProperty, string pPropertyValue, string pPropertyGroup, EmptyItem pEmptyItem)
    {
      var oRtn = new DropDownItems();
      if (pEmptyItem != EmptyItem.None)
        oRtn.Add(GetEmptyItem(pEmptyItem));
      foreach (var item in pList)
      {
        var wPropiedadMostrar = item.GetType().GetProperty(pShowProperty);
        var wPropiedadValor = item.GetType().GetProperty(pPropertyValue);
        var wPropiedadGrupo = item.GetType().GetProperty(pPropertyGroup);
        var oTextField = wPropiedadMostrar.GetValue(item, null);
        var oPropiedadValor = wPropiedadValor.GetValue(item, null);
        object oPropiedadGrupo = string.Empty;
        if (wPropiedadGrupo != null)
          oPropiedadGrupo = wPropiedadGrupo.GetValue(item, null);
        oRtn.Add(new DropDownItem(oPropiedadValor.ToString(), oTextField.ToString(), (oPropiedadGrupo != null ? oPropiedadGrupo.ToString() : string.Empty), false));
      }
      return oRtn;
    }
  }
}