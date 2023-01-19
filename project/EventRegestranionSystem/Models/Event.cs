﻿namespace EventRegestranionSystem.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly Date { get; set; }

        public Performance? Performance { get; set; }
    }
}
