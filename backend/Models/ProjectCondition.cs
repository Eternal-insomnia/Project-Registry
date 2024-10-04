using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProjectCondition
    {
        [Key]
        [ForeignKey("ProjectGeneralInfo")]
        public required Guid Id { get; set; }
        public string? Progress { get; set; }
        public string? GeneralStatus { get; set; }
        public string? Goals { get; set; }
        public string? Timelines { get; set; }
        public string? Budget { get; set; }
        public string? Contents { get; set; }
        public string? ReportLink { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
