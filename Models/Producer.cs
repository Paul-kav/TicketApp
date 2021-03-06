using System.ComponentModel.DataAnnotations;
using TicketApp.Data.Base;

namespace TicketApp.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name" )]
        public string? FullName { get; set; }
        [Display(Name ="Description")]
        public string? Description { get; set; }
        //Relationship
        public List<Movie>? Movies { get; set; }

        
    }
}
