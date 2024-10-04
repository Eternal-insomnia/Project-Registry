namespace Backend.DTOs.Views
{
    public class ProjectDocumentsViewDTO
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
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
