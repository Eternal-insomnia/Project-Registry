namespace Backend.DTOs.Views
{
    public class ProjectGeneralInfoViewDTO
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Activity { get; set; }
        public string? Program { get; set; }
        public string? RGT { get; set; }
        public string? Description { get; set; }
        public string? BusinessGoals { get; set; }
    }
}
