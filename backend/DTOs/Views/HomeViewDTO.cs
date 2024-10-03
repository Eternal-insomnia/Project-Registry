namespace Backend.DTOs.Views
{
    public class HomeViewDTO
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Priority { get; set; }
        public string? Progress { get; set; }
        public string? GeneralStatus { get; set; }
        public string? ActualEnd { get; set; }
        public string? Manager { get; set; }
        public string? Description { get; set; }
    }
}
