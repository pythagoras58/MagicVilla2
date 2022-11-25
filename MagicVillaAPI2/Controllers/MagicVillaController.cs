using MagicVillaAPI2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVillaAPI2.Controllers
{
    [Route("api/MagicVillaController")]
    [ApiController]
    public class MagicVillaController : ControllerBase
    {
        public IEnumerable<VillaModel> GetVillaModels()
        {
            return new List<VillaModel>
            {
                new VillaModel {Id=1, Name="Pool View"},
                new VillaModel {Id=2,Name="Beach View"}
            };
        }
    }
}
