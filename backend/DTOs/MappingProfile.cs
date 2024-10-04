using AutoMapper;
using Backend.Models.Views;

namespace Backend.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<string, string>()
                .ConvertUsing(src => src ?? string.Empty);

            CreateMap<NotDisplayedView, GeneralInfoMiniDTO>();
        }
    }
}
