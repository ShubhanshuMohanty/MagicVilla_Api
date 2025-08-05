
using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.VillaList;
        }

        [HttpGet("{id:int}")]
        public VillaDTO GetVilla(int id)
        {
            var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return null; // or throw an exception
            }
            return villa;
        }

    }
}
