namespace Backend.Models.Views
{
    public class CostView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Profitability { get; set; }
        public required string BaseCAPEXExt { get; set; }
        public required string BaseCAPEXWF { get; set; }
        public required string BaseOPEX { get; set; }
        public required string PassportCAPEXExt { get; set; }
        public required string PassportCAPEXWF { get; set; }
        public required string PassportOPEX { get; set; }
        public required string ActualCAPEXExt { get; set; }
        public required string ActualCAPEXWF { get; set; }
        public required string ActualOPEX { get; set; }
    }
}
