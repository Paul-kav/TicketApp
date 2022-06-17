using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById();
        void Update(int id, Actor newActor );
        Actor Add(int id);
        void Delete(int id);
        


    }
}
