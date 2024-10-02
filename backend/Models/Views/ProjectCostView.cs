namespace Backend.Models.Views
{
    public class ProjectCostView
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Profitability { get; set; }
        public float? BaseCAPEXExt { get; set; }
        public float? BaseCAPEXWF { get; set; }
        public float? BaseOPEX { get; set; }
        public float? PassportCAPEXExt { get; set; }
        public float? PassportCAPEXWF { get; set; }
        public float? PassportOPEX { get; set; }
        public float? ActualCAPEXExt { get; set; }
        public float? ActualCAPEXWF { get; set; }
        public float? ActualOPEX { get; set; }
    }
}
