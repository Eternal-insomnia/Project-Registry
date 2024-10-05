using Backend.Models;
using Backend.Models.Views;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class RepositoryContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ProjectGeneralInfo> ProjectGeneralInfo { get; set; }
        public DbSet<ProjectCondition>   ProjectCondition { get; set; }
        public DbSet<ProjectTeam>        ProjectTeam { get; set; }
        public DbSet<ProjectTimelines>   ProjectTimelines { get; set; }
        public DbSet<ProjectCost>        ProjectCost { get; set; }
        public DbSet<ProjectDocuments>   ProjectDocuments { get; set; }
        public DbSet<ProjectGoals>       ProjectGoals { get; set; }
        public DbSet<ProjectMonitoring>  ProjectMonitoring { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureForeignKeys(modelBuilder);
            ConfigureViews(modelBuilder);
        }

        private static void ConfigureForeignKeys(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Condition)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectCondition>(p => p.Id);
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Team)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectTeam>(p => p.Id);
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Timelines)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectTimelines>(p => p.Id);
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Cost)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectCost>(p => p.Id);
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Documents)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectDocuments>(p => p.Id);
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Goals)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectGoals>(p => p.Id);
            modelBuilder
                .Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Monitoring)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectMonitoring>(p => p.Id);
        }

        private static void ConfigureViews(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<HomeView>()
                .HasNoKey()
                .ToView("HomeView");
            modelBuilder
                .Entity<GeneralInfoView>()
                .HasNoKey()
                .ToView("GeneralInfoView");
            modelBuilder
                .Entity<ConditionView>()
                .HasNoKey()
                .ToView("ConditionView");
            modelBuilder
                .Entity<TeamView>()
                .HasNoKey()
                .ToView("TeamView");
            modelBuilder
                .Entity<TimelinesView>()
                .HasNoKey()
                .ToView("TimelinesView");
            modelBuilder
                .Entity<CostView>()
                .HasNoKey()
                .ToView("CostView");
            modelBuilder
                .Entity<DocumentsView>()
                .HasNoKey()
                .ToView("DocumentsView");
            modelBuilder
                .Entity<GoalsView>()
                .HasNoKey()
                .ToView("GoalsView");
            modelBuilder
                .Entity<MonitoringView>()
                .HasNoKey()
                .ToView("MonitoringView");
            modelBuilder
                .Entity<NotDisplayedView>()
                .HasNoKey()
                .ToView("NotDisplayedView");
        }
    }
}
