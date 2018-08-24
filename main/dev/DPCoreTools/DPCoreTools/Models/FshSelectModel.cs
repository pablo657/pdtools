using System.ComponentModel.DataAnnotations;
using DPCoreTools.SeedWork.Models;

namespace DPCoreTools.UI.Models
{
    public class FshSelectModel : DataPower
    {
    [Range( 1, 3)]
    public int Class { get; set; }
    }
}
