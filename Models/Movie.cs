using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketApp.Data.Base;
using TicketApp.Data.Enum;

namespace TicketApp.Models
{
    public class Movie: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string? Name { get; set; }
        [Display(Name ="Description")]
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Price { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }


        //Producer
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }
    }
}
