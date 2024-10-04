using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectMonitoring
    {
        [Key]
        [ForeignKey("ProjectGeneralInfo")]
        public required Guid Id { get; set; }
        public string? Sign { get; set; }
        public string? MonitoringStatus { get; set; }
        public string? EndYear { get; set; }
        public string? Product { get; set; }
        public string? Manager { get; set; }
        public string? Characteristics { get; set; }
        public string? ShortName { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
