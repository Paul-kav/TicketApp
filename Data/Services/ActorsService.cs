using Microsoft.EntityFrameworkCore;
using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public Actor Add(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var allActors = await _context.Actors.ToListAsync();
            return allActors;
        }

        public Actor GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
