﻿using TicketApp.Data;

namespace TicketApp.Models
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

        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public Cinema? CinemaId { get; set; }
        public Cinema? Cinema { get; set; }

        //Producer
        public Producer? ProducerId { get; set; }
        public Producer? Producer { get; set; }
    }
}
