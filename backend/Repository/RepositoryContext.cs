using ConsentCode.Models;
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
    }
}
