namespace Backend.Models
{
    public class ProjectConditionView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required int Progress { get; set; }
        public required int Goals { get; set; }
        public required int Deadlines { get; set; }
        public required int Budget { get; set; }
        public required int Content { get; set; }
        public required string ReportLink { get; set; }
    }
}
