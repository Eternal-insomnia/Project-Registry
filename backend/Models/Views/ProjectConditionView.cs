namespace Backend.Models.Views
{
    public class ProjectConditionView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public int? Progress { get; set; }
        public int? Goals { get; set; }
        public int? Deadlines { get; set; }
        public int? Budget { get; set; }
        public int? Contents { get; set; }
        public string? ReportLink { get; set; }
    }
}
