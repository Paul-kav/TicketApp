﻿namespace TicketApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
