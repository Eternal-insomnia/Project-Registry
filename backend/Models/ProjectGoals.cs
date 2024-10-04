using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectGoals
    {
        [Key]
        [ForeignKey("ProjectGeneralInfo")]
        public required Guid Id { get; set; }
        public string? Product { get; set; }
        public string? ImplCriteria { get; set; }
        public string? GoalsStatus { get; set; }
        public string? BusinessGoals { get; set; }
        public string? AchieveCriteria { get; set; }
        public string? BusinessGoalsStatus { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
