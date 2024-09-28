using ConsentCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsentCode.Repository
{
    public class RepositoryContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ProjectGeneralInfo> ProjectsGeneralInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectGeneralInfoConfiruation());
        }

        public async Task<List<ProjectGeneralInfo>> GetAllProjectsGeneralInfo() =>
            await ProjectsGeneralInfo.ToListAsync();
    }
}
