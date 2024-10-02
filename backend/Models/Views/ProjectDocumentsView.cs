namespace Backend.Models.Views
{
    public class ProjectDocumentsView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? ImplStartDecision { get; set; }
        public string? Timelines { get; set; }
        public string? Budget { get; set; }
        public string? Contents { get; set; }
        public string? StopResumeDecision { get; set; }
        public string? CloseCompleteDecision { get; set; }
    }
}
