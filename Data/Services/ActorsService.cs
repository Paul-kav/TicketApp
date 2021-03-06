using Microsoft.EntityFrameworkCore;
using TicketApp.Models;
using System.Threading.Tasks;
using TicketApp.Data.Base;

namespace TicketApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        //private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context)
        {
           // _context = context;
        }

       /* public async Task AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);//we first get the actor
            _context.Actors.Remove(result);

            await _context.SaveChangesAsync();
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


        public async Task<Actor>UpdateAsync(int id, Actor newActor)
        {

            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }*/

    }
}
