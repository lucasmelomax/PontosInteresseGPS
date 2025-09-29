using AutoMapper;
using GPS.Models;

namespace GPS.DTOs.Mappings {
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<PontosInteresse, PontosInteresseDTO>().ReverseMap();
        }
    }
}
