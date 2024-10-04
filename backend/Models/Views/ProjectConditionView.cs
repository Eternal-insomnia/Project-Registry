namespace Backend.Models.Views
{
    public class ProjectConditionView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Progress { get; set; }
        public string? Goals { get; set; }
        public string? Timelines { get; set; }
        public string? Budget { get; set; }
        public string? Contents { get; set; }
        public string? ReportLink { get; set; }
    }
}
