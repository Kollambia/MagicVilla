using MagicVilla_WebAPI.Controllers.DTO;

namespace MagicVilla_WebAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO { Id =  1, Name = "Pool Villa" },
            new VillaDTO { Id = 2, Name = "Beach Villa" }
        };
    }
}
