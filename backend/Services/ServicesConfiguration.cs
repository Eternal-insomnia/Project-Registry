using Backend.Models.Views;
using Backend.Services.Implementations;

namespace Backend.Services
{
    public static class ServicesConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ViewService<HomeView>>();
            services.AddScoped<ViewService<GeneralInfoView>>();
            services.AddScoped<ViewService<ConditionView>>();
            services.AddScoped<ViewService<TeamView>>();
            services.AddScoped<ViewService<ProjectTimelinesView>>();
            services.AddScoped<ViewService<CostView>>();
            services.AddScoped<ViewService<DocumentsView>>();
            services.AddScoped<ViewService<GoalsView>>();
            services.AddScoped<ViewService<MonitoringView>>();
            services.AddScoped<NotDisplayedViewService>();
        }
    }
}
