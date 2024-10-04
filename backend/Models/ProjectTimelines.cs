using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectTimelines
    {
        [Key]
        [ForeignKey("ProjectGeneralInfo")]
        public required Guid Id { get; set; }
        public string? PreStart { get; set; }
        public string? PreEndActual { get; set; }
        public string? PreDuration { get; set; }
        public string? PreEndPlanned { get; set; }
        public string? PreDeviation { get; set; }
        public string? ActualStart { get; set; }
        public string? ActualEnd { get; set; }
        public string? ActualDuration { get; set; }
        public string? BaseStart { get; set; }
        public string? BaseEnd { get; set; }
        public string? BaseDeviation { get; set; }
        public string? PassportEnd { get; set; }
        public string? PassportDeviation { get; set; }
        public string? PassportStartYear { get; set; }
        public string? PassportEndYear { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
