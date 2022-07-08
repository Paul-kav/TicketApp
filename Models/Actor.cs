using System.ComponentModel.DataAnnotations;
using TicketApp.Data.Base;

namespace TicketApp.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Full Name is required")]
        [Display(Name ="Full Name")]
        [StringLength(8)]
        public string? FullName { get; set; }
        //[StringLength(10, MinimumLength =25, ErrorMessage ="Biography must be between 10 and 25 chars")]

        public string? Biography { get; set; }
        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
