namespace Backend.Models.Views
{
    public class TeamView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Customer { get; set; }
        public required string Manager { get; set; }
        public required string TeamLead { get; set; }
        public required string BusinessAnalyst { get; set; }
        public required string MCPeople { get; set; }
    }
}
