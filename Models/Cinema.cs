using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string? FullName { get; set; }
        [Display(Name ="Description")]
        public string? Description { get; set; }

        //Relationship
        [NotMapped]
        public List<Movie>? Movies { get; set; }

        
    }
}
