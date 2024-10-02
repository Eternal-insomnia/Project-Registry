using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectDocuments
    {
        [Key]
        [ForeignKey("ProjectsGeneralInfo")]
        public required Guid Id { get; set; }
        public string? PrePStartDecision { get; set; }
        public string? ImplStartDecision { get; set; }
        public string? Timelines { get; set; }
        public string? ReasonCRTimelines { get; set; }
        public string? Budget { get; set; }
        public string? ReasonCRBudget { get; set; }
        public string? Contents { get; set; }
        public string? ReasonCRContents { get; set; }
        public string? StopResumeDecision { get; set; }
        public string? StopReason { get; set; }
        public string? CloseCompleteDecision { get; set; }
        public string? CloseReason { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
