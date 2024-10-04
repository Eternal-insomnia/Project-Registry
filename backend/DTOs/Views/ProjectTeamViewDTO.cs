namespace Backend.DTOs.Views
{
    public class ProjectTeamViewDTO
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Customer { get; set; }
        public string? Manager { get; set; }
        public string? TeamLead { get; set; }
        public string? BusinessAnalyst { get; set; }
        public string? MCPeople { get; set; }
    }
}
