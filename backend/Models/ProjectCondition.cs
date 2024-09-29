using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsentCode.Models
{
    public class ProjectCondition
    {
        [Key]
        [ForeignKey("ProjectsGeneralInfo")]
        public required Guid Id { get; set; }
        public required int Progress { get; set; }
        public string? Status { get; set; }
        public required int Goals { get; set; }
        public required int Deadlines { get; set; }
        public required int Budget { get; set; }
        public required int Content { get; set; }
        public required string ReportLink { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
