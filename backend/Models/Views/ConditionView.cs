namespace Backend.Models.Views
{
    public class ConditionView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Progress { get; set; }
        public required string Goals { get; set; }
        public required string Timelines { get; set; }
        public required string Budget { get; set; }
        public required string Contents { get; set; }
        public required string ReportLink { get; set; }
    }
}
