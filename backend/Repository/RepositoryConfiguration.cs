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
            services.AddScoped(typeof(IViewRepository<ProjectTimelinesView>), typeof(ViewRepository<ProjectTimelinesView>));
            services.AddScoped(typeof(IViewRepository<CostView>),             typeof(ViewRepository<CostView>));
            services.AddScoped(typeof(IViewRepository<DocumentsView>),        typeof(ViewRepository<DocumentsView>));
            services.AddScoped(typeof(IViewRepository<GoalsView>),            typeof(ViewRepository<GoalsView>));
            services.AddScoped(typeof(IViewRepository<MonitoringView>),       typeof(ViewRepository<MonitoringView>));
            services.AddScoped(typeof(IViewRepository<NotDisplayedView>),     typeof(ViewRepository<NotDisplayedView>));
        }
    }
}
