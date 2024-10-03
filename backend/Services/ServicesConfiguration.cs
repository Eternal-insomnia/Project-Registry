using Backend.DTOs.Views;
using Backend.Services.Implementations;

namespace Backend.Services
{
    public static class ServicesConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ViewService<HomeViewDTO>>();
            services.AddScoped<ViewService<ProjectGeneralInfoViewDTO>>();
            services.AddScoped<ViewService<ProjectConditionViewDTO>>();
            services.AddScoped<ViewService<ProjectTeamViewDTO>>();
            services.AddScoped<ViewService<ProjectTimelinesViewDTO>>();
            services.AddScoped<ViewService<ProjectCostViewDTO>>();
            services.AddScoped<ViewService<ProjectDocumentsViewDTO>>();
            services.AddScoped<ViewService<ProjectGoalsViewDTO>>();
            services.AddScoped<ViewService<ProjectMonitoringViewDTO>>();
        }
    }
}
