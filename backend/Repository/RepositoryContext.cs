﻿using Backend.Models;
using Backend.Models.Views;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class RepositoryContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ProjectGeneralInfo> ProjectsGeneralInfo { get; set; }
        public DbSet<ProjectCondition> ProjectsCondition { get; set; }
        public DbSet<ProjectTeam> ProjectsTeam { get; set; }
        public DbSet<ProjectGoals> ProjectsGoals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
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
                .HasOne(u => u.Goals)
                .WithOne(p => p.GeneralInfo)
                .HasForeignKey<ProjectGoals>(p => p.Id);

            modelBuilder
                .Entity<ProjectConditionView>()
                .HasNoKey()
                .ToView("ProjectsConditionView");
            modelBuilder
                .Entity<ProjectTeamView>()
                .HasNoKey()
                .ToView("ProjectsTeamView");
            modelBuilder
                .Entity<ProjectGoalsView>()
                .HasNoKey()
                .ToView("ProjectsGoalsView");
        }
    }
}
