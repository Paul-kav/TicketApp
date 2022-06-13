using System.ComponentModel.DataAnnotations;

namespace TicketApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Biography { get; set; }
        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
