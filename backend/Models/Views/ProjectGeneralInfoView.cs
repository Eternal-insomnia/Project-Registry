namespace Backend.Models.Views
{
    public class ProjectGeneralInfoView
    {
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
