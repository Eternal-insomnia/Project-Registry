using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectTimelines
    {
        [Key]
        [ForeignKey("ProjectsGeneralInfo")]
        public required Guid Id { get; set; }
        public DateOnly? PreStart { get; set; }
        public DateOnly? PreEndActual { get; set; }
        public int? PreDuration { get; set; }
        public DateOnly? PreEndPlanned { get; set; }
        public int? PreDeviation { get; set; }
        public DateOnly? ActualStart { get; set; }
        public DateOnly? ActualEnd { get; set; }
        public int? ActualDuration { get; set; }
        public DateOnly? BaseStart { get; set; }
        public DateOnly? BaseEnd { get; set; }
        public int? BaseDeviation { get; set; }
        public DateOnly? PassportEnd { get; set; }
        public int? PassportDeviation { get; set; }
        public int? PassportStartYear { get; set; }
        public int? PassportEndYear { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
