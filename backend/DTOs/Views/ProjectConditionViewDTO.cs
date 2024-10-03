namespace Backend.DTOs.Views
{
    public class ProjectConditionViewDTO
    {
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
