﻿namespace Backend.Models.Views
{
    public class HomeView
    {
        public required Guid Id { get; set; }
        public required string Year { get; set; }
        public required string Status { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string Stage { get; set; }
        public required string Priority { get; set; }
        public required string Progress { get; set; }
        public required string GeneralStatus { get; set; }
        public required string ActualEnd { get; set; }
        public required string Manager { get; set; }
        public required string Description { get; set; }
    }
}
