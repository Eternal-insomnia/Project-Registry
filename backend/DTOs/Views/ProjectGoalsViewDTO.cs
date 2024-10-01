namespace Backend.DTOs.Views
{
    public class ProjectGoalsViewDTO
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Product { get; set; }
        public string? ImplCriteria { get; set; }
        public string? GoalsStatus { get; set; }
        public string? BusinessGoals { get; set; }
        public string? AchieveCriteria { get; set; }
        public string? BusinessGoalsStatus { get; set; }
    }
}
