﻿using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProjectGeneralInfo
    {
        [Key]
        public required Guid Id { get; set; }

        public string? Year { get; set; }
        public string? Status { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Stage { get; set; }
        public string? Priority { get; set; }

        public string? PostMonitoring { get; set; }
        public string? Activity { get; set; }
        public string? Category { get; set; }
        public string? Program { get; set; }
        public string? StrategyBelonging { get; set; }
        public string? RGT { get; set; }
        public string? Description { get; set; }
        public string? Dependencies { get; set; }

        public ProjectCondition? Condition { get; set; }
        public ProjectTeam? Team { get; set; }
        public ProjectTimelines? Timelines { get; set; }
        public ProjectCost? Cost { get; set; }
        public ProjectDocuments? Documents { get; set; }
        public ProjectGoals? Goals { get; set; }
        public ProjectMonitoring? Monitoring { get; set; }
    }
}
