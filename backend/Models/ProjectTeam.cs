using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectTeam
    {
        [Key]
        [ForeignKey("ProjectGeneralInfo")]
        public required Guid Id { get; set; }
        public string? Customer { get; set; }
        public string? ProductOwner { get; set; }
        public string? Manager { get; set; }
        public string? TeamLead { get; set; }
        public string? BusinessAnalyst { get; set; }
        public string? MCPeople { get; set; }
        public string? Stakeholders { get; set; }
        public string? ExternalPeople { get; set; }
        public string? ADM { get; set; }
        public string? FRC { get; set; }
        public string? BusinessLines { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
