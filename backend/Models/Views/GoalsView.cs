namespace Backend.Models.Views
{
    public class GoalsView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Product { get; set; }
        public required string ImplCriteria { get; set; }
        public required string GoalsStatus { get; set; }
        public required string BusinessGoals { get; set; }
        public required string AchieveCriteria { get; set; }
        public required string BusinessGoalsStatus { get; set; }
    }
}
