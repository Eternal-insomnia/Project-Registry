namespace Backend.Models.Views
{
    public class NotDisplayedView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Priority { get; set; }
        public required string PostMonitoring { get; set; }
        public required string Category { get; set; }
        public required string StrategyBelonging { get; set; }
        public required string RGT { get; set; }
        public required string Dependencies { get; set; }

        public required string GeneralStatus { get; set; }

        public required string ProductOwner { get; set; }
        public required string Stakeholders { get; set; }
        public required string ExternalPeople { get; set; }
        public required string ADM { get; set; }
        public required string FRC { get; set; }
        public required string BusinessLines { get; set; }

        public required string PreStart { get; set; }
        public required string PreEndActual { get; set; }
        public required string PreDuration { get; set; }
        public required string PreEndPlanned { get; set; }
        public required string PreDeviation { get; set; }
        public required string BaseStart { get; set; }
        public required string PassportEnd { get; set; }
        public required string PassportDeviation { get; set; }

        public required string PreCAPEXExt { get; set; }
        public required string PreCAPEXWF { get; set; }
        public required string PreOPEX { get; set; }
        public required string PreCAPEXExtActual { get; set; }
        public required string PreCAPEXExtDeltaPercent { get; set; }
        public required string PassportCAPEXExtDelta { get; set; }
        public required string PassportCAPEXExtDeltaPercent { get; set; }
        public required string ActualCAPEXExtDelta { get; set; }
        public required string ActualCAPEXExtDeltaPercent { get; set; }

        public required string PrePStartDecision { get; set; }
        public required string ReasonCRTimelines { get; set; }
        public required string ReasonCRBudget { get; set; }
        public required string ReasonCRContents { get; set; }
        public required string StopReason { get; set; }
        public required string CloseReason { get; set; }
    }
}
