using AutoMapper;
using Backend.DTOs.Views;
using Backend.Models;
using Backend.Models.Views;

namespace Backend.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProjectGeneralInfo, ProjectGeneralInfoDTO>()
                .AddTransform<string>(s => s ?? string.Empty);
            CreateMap<ProjectConditionView, ProjectConditionViewDTO>()
                .AddTransform<string>(s => s ?? string.Empty);
            CreateMap<ProjectTeamView, ProjectTeamViewDTO>()
                .AddTransform<string>(s => s ?? string.Empty);
            CreateMap<ProjectGoalsView, ProjectGoalsViewDTO>()
                .AddTransform<string>(s => s ?? string.Empty);
        }
    }
}
