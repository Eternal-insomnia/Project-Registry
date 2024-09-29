using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsentCode.Models
{
    public class ProjectGeneralInfo
    {
        [Key]
        public Guid Id { get; set; }

        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }

        [Column(TypeName = "float4")]
        public required float Priority { get; set; }

        public string? Monitoring { get; set; }
        public string? Activity { get; set; }
        public string? Category { get; set; }
        public string? Program { get; set; }
        public string? StrategyBelonging { get; set; }

        [Column(TypeName = "char")]
        public string? RGT { get; set; }

    }
}
