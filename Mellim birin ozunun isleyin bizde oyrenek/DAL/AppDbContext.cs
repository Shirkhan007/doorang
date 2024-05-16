using Mellim_birin_ozunun_isleyin_bizde_oyrenek.Models;
using Microsoft.EntityFrameworkCore;

namespace Mellim_birin_ozunun_isleyin_bizde_oyrenek.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Explore> Explores { get; set; }
    }
}
