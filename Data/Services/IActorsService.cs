using TicketApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TicketApp.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task<Actor> UpdateAsync(int id, Actor newActor );
        Task AddAsync(Actor actor);
        void Delete(int id);
        


    }
}
