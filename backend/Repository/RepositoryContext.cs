using Backend.Models;
using Backend.Models.Views;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class RepositoryContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ProjectGeneralInfo> ProjectGeneralInfo { get; set; }
        public DbSet<ProjectCondition> ProjectCondition { get; set; }
        public DbSet<ProjectTeam> ProjectTeam { get; set; }
        public DbSet<ProjectTimelines> ProjectTimelines { get; set; }
        public DbSet<ProjectCost> ProjectCost { get; set; }
        public DbSet<ProjectDocuments> ProjectDocuments { get; set; }
        public DbSet<ProjectGoals> ProjectGoals { get; set; }
        public DbSet<ProjectMonitoring> ProjectMonitoring { get; set; }

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
                .Entity<ProjectGeneralInfoView>()
                .HasNoKey()
                .ToView("ProjectGeneralInfoView");
            modelBuilder
                .Entity<ProjectConditionView>()
                .HasNoKey()
                .ToView("ProjectConditionView");
            modelBuilder
                .Entity<ProjectTeamView>()
                .HasNoKey()
                .ToView("ProjectTeamView");
            modelBuilder
                .Entity<ProjectTimelinesView>()
                .HasNoKey()
                .ToView("ProjectTimelinesView");
            modelBuilder
                .Entity<ProjectCostView>()
                .HasNoKey()
                .ToView("ProjectCostView");
            modelBuilder
                .Entity<ProjectDocumentsView>()
                .HasNoKey()
                .ToView("ProjectDocumentsView");
            modelBuilder
                .Entity<ProjectGoalsView>()
                .HasNoKey()
                .ToView("ProjectGoalsView");
            modelBuilder
                .Entity<ProjectMonitoringView>()
                .HasNoKey()
                .ToView("ProjectMonitoringView");
        }
    }
}
