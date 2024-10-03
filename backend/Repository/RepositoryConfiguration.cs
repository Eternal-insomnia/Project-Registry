using Backend.DTOs.Views;
using Backend.Models.Views;
using Backend.Repository.Implementations;
using Backend.Repository.Interfaces;

namespace Backend.Repository
{
    public static class RepositoryConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IViewRepository<HomeViewDTO>), typeof(ViewRepository<HomeView, HomeViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectGeneralInfoViewDTO>), typeof(ViewRepository<ProjectGeneralInfoView, ProjectGeneralInfoViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectConditionViewDTO>), typeof(ViewRepository<ProjectConditionView, ProjectConditionViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectTeamViewDTO>), typeof(ViewRepository<ProjectTeamView, ProjectTeamViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectTimelinesViewDTO>), typeof(ViewRepository<ProjectTimelinesView, ProjectTimelinesViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectCostViewDTO>), typeof(ViewRepository<ProjectCostView, ProjectCostViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectDocumentsViewDTO>), typeof(ViewRepository<ProjectDocumentsView, ProjectDocumentsViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectGoalsViewDTO>), typeof(ViewRepository<ProjectGoalsView, ProjectGoalsViewDTO>));
            services.AddScoped(typeof(IViewRepository<ProjectMonitoringViewDTO>), typeof(ViewRepository<ProjectMonitoringView, ProjectMonitoringViewDTO>));
        }
    }
}
