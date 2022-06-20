using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync();
        Actor Update(int id, Actor newActor );
        Task AddAsync(Actor actor);
        void Delete(int id);
        


    }
}
