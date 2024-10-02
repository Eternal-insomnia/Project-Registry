namespace Backend.Models.Views
{
    public class ProjectTimelinesView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public DateOnly? ActualStart { get; set; }
        public DateOnly? ActualEnd { get; set; }
        public int? ActualDuration { get; set; }
        public DateOnly? BaseEnd { get; set; }
        public int? BaseDeviation { get; set; }
        public int? PassportStartYear { get; set; }
        public int? PassportEndYear { get; set; }
    }
}
