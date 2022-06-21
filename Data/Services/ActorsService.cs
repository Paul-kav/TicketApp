using Microsoft.EntityFrameworkCore;
using TicketApp.Models;
using System.Threading.Tasks;

namespace TicketApp.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var allActors = await _context.Actors.ToListAsync();
            return allActors;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Task<Actor> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Actor>UpdateAsync(int id, Actor newActor)
        {

            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }

    }
}
