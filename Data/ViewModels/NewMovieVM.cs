using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketApp.Data.Base;
using TicketApp.Data.Enum;

namespace TicketApp.Models
{
    public class NewMovieVM
    {
        [Display(Name="Movie Name")]
        [Required(ErrorMessage ="Name is required")]
        public string? Name { get; set; }
        
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Price in US $")]
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]

        public MovieCategory MovieCategory { get; set; }


        //Relationship
        [Display(Name = "Select actor")]
        [Required(ErrorMessage = "Movie actor is required")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is required")]

        public int ProducerId { get; set; }
        
    }
}
