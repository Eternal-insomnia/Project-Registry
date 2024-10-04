namespace Backend.DTOs.Views
{
    public class ProjectMonitoringViewDTO
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
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
