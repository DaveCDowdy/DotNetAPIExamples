using AutoMapper;
using MagicVilla_VIllaAPI.Models;
using MagicVilla_VIllaAPI.Models.DTO;

namespace MagicVilla_VIllaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
