using TicketApp.Data.Base;
using TicketApp.Data.ViewModels;
using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownValues();
    }
}
