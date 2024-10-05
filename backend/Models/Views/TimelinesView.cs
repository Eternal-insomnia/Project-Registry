namespace Backend.Models.Views
{
    public class TimelinesView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string ActualStart { get; set; }
        public required string ActualEnd { get; set; }
        public required string ActualDuration { get; set; }
        public required string BaseEnd { get; set; }
        public required string BaseDeviation { get; set; }
        public required string PassportStartYear { get; set; }
        public required string PassportEndYear { get; set; }
    }
}
