using Backend.Models;
using Backend.Models.Views;
using Backend.Repository.Implementations;
using Backend.Repository.Interfaces;

namespace Backend.Repository
{
    public static class RepositoryConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IViewRepository<HomeView>),             typeof(ViewRepository<HomeView>));
            services.AddScoped(typeof(IViewRepository<GeneralInfoView>),      typeof(ViewRepository<GeneralInfoView>));
            services.AddScoped(typeof(IViewRepository<ConditionView>),        typeof(ViewRepository<ConditionView>));
            services.AddScoped(typeof(IViewRepository<TeamView>),             typeof(ViewRepository<TeamView>));
            services.AddScoped(typeof(IViewRepository<TimelinesView>), typeof(ViewRepository<TimelinesView>));
            services.AddScoped(typeof(IViewRepository<CostView>),             typeof(ViewRepository<CostView>));
            services.AddScoped(typeof(IViewRepository<DocumentsView>),        typeof(ViewRepository<DocumentsView>));
            services.AddScoped(typeof(IViewRepository<GoalsView>),            typeof(ViewRepository<GoalsView>));
            services.AddScoped(typeof(IViewRepository<MonitoringView>),       typeof(ViewRepository<MonitoringView>));
            services.AddScoped(typeof(IViewRepository<NotDisplayedView>),     typeof(ViewRepository<NotDisplayedView>));

            services.AddScoped(typeof(IImportRepository<ProjectGeneralInfo>), typeof(ImportRepository<ProjectGeneralInfo>));
            services.AddScoped(typeof(IImportRepository<ProjectCondition>),   typeof(ImportRepository<ProjectCondition>));
            services.AddScoped(typeof(IImportRepository<ProjectTeam>),        typeof(ImportRepository<ProjectTeam>));
            services.AddScoped(typeof(IImportRepository<ProjectTimelines>),   typeof(ImportRepository<ProjectTimelines>));
            services.AddScoped(typeof(IImportRepository<ProjectCost>),        typeof(ImportRepository<ProjectCost>));
            services.AddScoped(typeof(IImportRepository<ProjectDocuments>),   typeof(ImportRepository<ProjectDocuments>));
            services.AddScoped(typeof(IImportRepository<ProjectGoals>),       typeof(ImportRepository<ProjectGoals>));
            services.AddScoped(typeof(IImportRepository<ProjectMonitoring>),  typeof(ImportRepository<ProjectMonitoring>));
        }
    }
}
