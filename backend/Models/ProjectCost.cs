using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectCost
    {
        [Key]
        [ForeignKey("ProjectsGeneralInfo")]
        public required Guid Id { get; set; }
        public string? Profitability { get; set; }
        public float? PreCAPEXExt { get; set; }
        public float? PreCAPEXWF { get; set; }
        public float? PreOPEX { get; set; }
        public float? PreCAPEXExtActual { get; set; }
        public float? PreCAPEXExtDeltaPercent { get; set; }
        public float? BaseCAPEXExt { get; set; }
        public float? BaseCAPEXWF { get; set; }
        public float? BaseOPEX { get; set; }
        public float? PassportCAPEXExt { get; set; }
        public float? PassportCAPEXWF { get; set; }
        public float? PassportOPEX { get; set; }
        public float? PassportCAPEXExtDelta { get; set; }
        public float? PassportCAPEXExtDeltaPercent { get; set; }
        public float? ActualCAPEXExt { get; set; }
        public float? ActualCAPEXWF { get; set; }
        public float? ActualOPEX { get; set; }
        public float? ActualCAPEXExtDelta { get; set; }
        public float? ActualCAPEXExtDeltaPercent { get; set; }

        public required ProjectGeneralInfo GeneralInfo { get; set; }
    }
}
