namespace Backend.Models.Views
{
    public class HomeView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public float? Priority { get; set; }
        public int? Progress { get; set; }
        public string? GeneralStatus { get; set; }
        public DateOnly? ActualEnd { get; set; }
        public string? Manager { get; set; }
        public string? Description { get; set; }
    }
}
