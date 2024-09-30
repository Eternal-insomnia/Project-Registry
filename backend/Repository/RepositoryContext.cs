using AutoMapper;
using Backend.Models;
using Backend.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class RepositoryContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ProjectGeneralInfo> ProjectsGeneralInfo { get; set; }
        public DbSet<ProjectCondition> ProjectsCondition { get; set; }
        public DbSet<ProjectConditionView> ProjectsConditionView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectGeneralInfo>()
                .HasOne(u => u.Condition)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectCondition>(p => p.Id);
            modelBuilder.Entity<ProjectConditionView>()
                .HasNoKey() // Представление не имеет первичного ключа
                .ToView("ProjectConditionView");
            //modelBuilder.ApplyConfiguration(new ProjectGeneralInfoConfiruation());
            //modelBuilder.ApplyConfiguration(new ProjectConditionConfiguration());
        }
    }
}
