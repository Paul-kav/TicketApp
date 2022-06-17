using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public interface Actors
    {
        IEnumerable<Actors> GetAll();
        Actor GetById();
        void Update(int id, Actor newActor );
        Actor Add(int id);
        void Delete(int id);



    }
}
