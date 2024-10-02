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
            CreateMap<DateOnly?, string>()
                .ConvertUsing(src => src.HasValue ? src.Value.ToString("dd.MM.yyyy") : string.Empty);

            CreateMap<string, string>()
                .ConvertUsing(src => src ?? string.Empty);

            CreateMap<float?, string>()
                .ConvertUsing(src => src.HasValue ? src.Value.ToString() : string.Empty);

            CreateMap<int?, string>()
                .ConvertUsing(src => src.HasValue ? src.Value.ToString() : string.Empty);

            CreateMap<ProjectGeneralInfo, ProjectGeneralInfoDTO>();
            CreateMap<ProjectConditionView, ProjectConditionViewDTO>();
            CreateMap<ProjectTeamView, ProjectTeamViewDTO>();
            CreateMap<ProjectTimelinesView, ProjectTimelinesViewDTO>();
            CreateMap<ProjectCostView, ProjectCostViewDTO>();
            CreateMap<ProjectDocumentsView, ProjectDocumentsViewDTO>();
            CreateMap<ProjectGoalsView, ProjectGoalsViewDTO>();
        }
    }
}
