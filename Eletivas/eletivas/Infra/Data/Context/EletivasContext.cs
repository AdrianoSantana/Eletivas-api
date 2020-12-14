using eletivas.Models;
using Microsoft.EntityFrameworkCore;

namespace eletivas.Data
{
    public class EletivasContext : DbContext
    {
        public EletivasContext(DbContextOptions<EletivasContext> options) : base(options)
        {
            
        }

        public DbSet<Eletivas> Eletivas { get; set; }
    }
}