using Microsoft.EntityFrameworkCore;

namespace TicketApp.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
            { }
    }
}
