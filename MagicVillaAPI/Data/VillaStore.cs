using MagicVillaAPI.Models.Dto;
using System.Net.NetworkInformation;

namespace MagicVillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO {Id = 1,Name="Pool View",Occupancy = 2,Sqft=100 },
            new VillaDTO {Id = 2,Name="Beach View" ,Occupancy = 4,Sqft=300 }
        };
    }
}
