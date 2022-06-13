using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Description { get; set; }

        //Relationship
        [NotMapped]
        public List<Movie>? Movies { get; set; }

        //public static implicit operator Cinema(int v)
        //{
           // throw new NotImplementedException();
       // }
    }
}
