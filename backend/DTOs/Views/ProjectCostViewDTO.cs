﻿namespace Backend.DTOs.Views
{
    public class ProjectCostViewDTO
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public string? Profitability { get; set; }
        public string? BaseCAPEXExt { get; set; }
        public string? BaseCAPEXWF { get; set; }
        public string? BaseOPEX { get; set; }
        public string? PassportCAPEXExt { get; set; }
        public string? PassportCAPEXWF { get; set; }
        public string? PassportOPEX { get; set; }
        public string? ActualCAPEXExt { get; set; }
        public string? ActualCAPEXWF { get; set; }
        public string? ActualOPEX { get; set; }
    }
}
