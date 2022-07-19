using TicketApp.Data.Base;
using TicketApp.Models;

namespace TicketApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }

        /*public Task AddAsync(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cinema>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cinema> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Cinema entity)
        {
            throw new NotImplementedException();
        }*/
    }
}
