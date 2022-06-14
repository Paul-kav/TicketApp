using System.ComponentModel.DataAnnotations;

namespace TicketApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name" )]
        public string? FullName { get; set; }
        [Display(Name ="Description")]
        public string? Description { get; set; }
        //Relationship
        public List<Movie>? Movies { get; set; }

        /*public static implicit operator Producer(int v)
        {
            throw new NotImplementedException();
        }*/
    }
}
