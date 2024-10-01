namespace Backend.Models.Views
{
    public class ProjectTeamView
    {
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
