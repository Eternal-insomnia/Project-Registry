using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProjectCondition
    {
        [Key]
        [ForeignKey("ProjectsGeneralInfo")]
        public required Guid Id { get; set; }
        public int? Progress { get; set; }
        public string? Status { get; set; }
        public int? Goals { get; set; }
        public int? Deadlines { get; set; }
        public int? Budget { get; set; }
        public int? Contents { get; set; }
        public string? ReportLink { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
