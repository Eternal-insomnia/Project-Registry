using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Repository.Configurations
{
    public class ProjectGeneralInfoConfiruation : IEntityTypeConfiguration<ProjectGeneralInfo>
    {
        public void Configure(EntityTypeBuilder<ProjectGeneralInfo> builder)
        {
            builder.HasKey(p => p.Id);

            //builder.HasData
            //(
            //new ProjectGeneralInfo
            //{
            //    Id = new Guid("02a7663b-71f1-4d78-9e5e-5d76f584c4af"),
            //    Year = "24",
            //    Status = "Archived",
            //    Code = "COC1",
            //    Name = "Web App",
            //    Stage = "In Progress",
            //    Priority = 7
            //},
            //new ProjectGeneralInfo
            //{
            //    Id = new Guid("2dd1c9ed-3350-484a-81a5-061e566b13a9"),
            //    Year = "23",
            //    Status = "Archived",
            //    Code = "preCOC",
            //    Name = "Game",
            //    Stage = "Done",
            //    Priority = 3
            //}
            //);
        }
    }
}
