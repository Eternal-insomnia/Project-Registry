namespace Backend.Models.Views
{
    public class MonitoringView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Sign { get; set; }
        public required string MonitoringStatus { get; set; }
        public required string EndYear { get; set; }
        public required string Product { get; set; }
        public required string Manager { get; set; }
        public required string Characteristics { get; set; }
        public required string ShortName { get; set; }
    }
}
