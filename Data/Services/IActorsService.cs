using TicketApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using TicketApp.Data.Base;

namespace TicketApp.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
       /* Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task<Actor> UpdateAsync(int id, Actor newActor );
        Task AddAsync(Actor actor);
        Task DeleteAsync(int id);*/
        


    }
}
