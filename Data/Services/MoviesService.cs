using TicketApp.Data.Base;
using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context)
        {
        }

        
    }
}
