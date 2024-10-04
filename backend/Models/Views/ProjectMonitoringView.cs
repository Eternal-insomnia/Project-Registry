namespace Backend.Models.Views
{
    public class ProjectMonitoringView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Sign { get; set; }
        public string? MonitoringStatus { get; set; }
        public string? EndYear { get; set; }
        public string? Product { get; set; }
        public string? Manager { get; set; }
        public string? Characteristics { get; set; }
        public string? ShortName { get; set; }
    }
}
