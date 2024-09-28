using ConsentCode.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsentCode.Repository
{
    public class ProjectGeneralInfoConfiruation : IEntityTypeConfiguration<ProjectGeneralInfo>
    {
        public void Configure(EntityTypeBuilder<ProjectGeneralInfo> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasData
            (
            new ProjectGeneralInfo
            {
                Id = Guid.NewGuid(),
                Year = "24",
                Status = "Archived",
                Code = "COC1",
                Name = "Web App",
                Stage = "In Progress",
                Priority = 7
            },
            new ProjectGeneralInfo
            {
                Id = Guid.NewGuid(),
                Year = "23",
                Status = "Archived",
                Code = "preCOC",
                Name = "Game",
                Stage = "Done",
                Priority = 3
            }
            );
        }
    }
}
