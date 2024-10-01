using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProjectGeneralInfo
    {
        [Key]
        public required Guid Id { get; set; }

        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }

        [Column(TypeName = "float4")]
        public float? Priority { get; set; }

        public string? Monitoring { get; set; }
        public string? Activity { get; set; }
        public string? Category { get; set; }
        public string? Program { get; set; }
        public string? StrategyBelonging { get; set; }

        [Column(TypeName = "char")]
        public string? RGT { get; set; }
        public string? Description { get; set; }


        public ProjectCondition? Condition { get; set; }
        public ProjectTeam? Team { get; set; }
        public ProjectGoals? Goals { get; set; }
    }
}
