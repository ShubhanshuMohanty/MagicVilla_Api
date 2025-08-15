using AutoMapper;
using MagicVilla_VillaApi.Models.Dto;
using MagicVilla_VillaApi.Models;
namespace MagicVilla_VillaApi
{
    public class MappingConfig :Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
