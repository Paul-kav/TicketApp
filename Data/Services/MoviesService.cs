using Microsoft.EntityFrameworkCore;
using TicketApp.Data.Base;
using TicketApp.Data.ViewModels;
using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);
            return movieDetails;

        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownValues()
        {
            var response = new NewMovieDropdownsVM();
            response.Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync();
            response.Cinemas = await _context.Cinemas.OrderBy(n => n.FullName).ToListAsync();
            response.Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync();
            return response;
        }
    }
}
