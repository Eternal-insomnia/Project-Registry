using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Repository.Configurations
{
    public class ProjectConditionConfiguration : IEntityTypeConfiguration<ProjectCondition>
    {
        public void Configure(EntityTypeBuilder<ProjectCondition> builder)
        {
            builder.HasKey(p => p.Id);

            //builder.HasData
            //(
            //new ProjectCondition
            //{
            //    Id = new Guid("02a7663b-71f1-4d78-9e5e-5d76f584c4af"),
            //    Progress = 50,
            //    Status = "Almost Archived",
            //    Goals = 4,
            //    Deadlines = 1,
            //    Budget = 100,
            //    Content = 7,
            //    ReportLink = "www.ya.ru"
            //},
            //new ProjectCondition
            //{
            //    Id = Guid.NewGuid(),
            //    Progress = 86,
            //    Status = "Undead",
            //    Goals = 8,
            //    Deadlines = 18,
            //    Budget = 1000,
            //    Content = 3,
            //    ReportLink = "www.ya.ru"
            //}
            //);
        }
    }
}
