namespace Backend.DTOs.Views
{
    public class ProjectTimelinesViewDTO
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? ActualStart { get; set; }
        public string? ActualEnd { get; set; }
        public string? ActualDuration { get; set; }
        public string? BaseEnd { get; set; }
        public string? BaseDeviation { get; set; }
        public string? PassportStartYear { get; set; }
        public string? PassportEndYear { get; set; }
    }
}
