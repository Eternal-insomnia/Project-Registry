namespace Backend.Models.Views
{
    public class GeneralInfoView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Activity { get; set; }
        public required string Program { get; set; }
        public required string RGT { get; set; }
        public required string Description { get; set; }
        public required string BusinessGoals { get; set; }
    }
}
