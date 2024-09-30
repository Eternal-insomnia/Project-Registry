using AutoMapper;
using Backend.DTOs;
using Backend.Models;

namespace Backend.Repository
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProjectGeneralInfo, ProjectGeneralInfoDTO>()
                .ForMember(dest => dest.Activity, opt => opt.MapFrom(src => src.Activity ?? string.Empty))
                .ForMember(dest => dest.Program,  opt => opt.MapFrom(src => src.Program  ?? string.Empty))
                .ForMember(dest => dest.RGT,      opt => opt.MapFrom(src => src.RGT      ?? string.Empty));
            CreateMap<ProjectConditionView, ProjectConditionViewDTO>();
        }
    }
}
