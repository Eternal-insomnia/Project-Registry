using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectCost
    {
        [Key]
        [ForeignKey("ProjectGeneralInfo")]
        public required Guid Id { get; set; }
        public string? Profitability { get; set; }
        public string? PreCAPEXExt { get; set; }
        public string? PreCAPEXWF { get; set; }
        public string? PreOPEX { get; set; }
        public string? PreCAPEXExtActual { get; set; }
        public string? PreCAPEXExtDeltaPercent { get; set; }
        public string? BaseCAPEXExt { get; set; }
        public string? BaseCAPEXWF { get; set; }
        public string? BaseOPEX { get; set; }
        public string? PassportCAPEXExt { get; set; }
        public string? PassportCAPEXWF { get; set; }
        public string? PassportOPEX { get; set; }
        public string? PassportCAPEXExtDelta { get; set; }
        public string? PassportCAPEXExtDeltaPercent { get; set; }
        public string? ActualCAPEXExt { get; set; }
        public string? ActualCAPEXWF { get; set; }
        public string? ActualOPEX { get; set; }
        public string? ActualCAPEXExtDelta { get; set; }
        public string? ActualCAPEXExtDeltaPercent { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
