namespace Backend.DTOs.Views
{
    public class ProjectTimelinesViewDTO
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? ActualStart { get; set; }
        public string? ActualEnd { get; set; }
        public int? ActualDuration { get; set; }
        public string? BaseEnd { get; set; }
        public int? BaseDeviation { get; set; }
        public int? PassportStartYear { get; set; }
        public int? PassportEndYear { get; set; }
    }
}
