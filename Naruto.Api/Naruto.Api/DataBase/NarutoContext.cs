using Microsoft.EntityFrameworkCore;
using Naruto.Api.Models;

namespace Naruto.Api.DataBase
{
    public class NarutoContext : DbContext
    {
        public NarutoContext(DbContextOptions<NarutoContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Poder> Poderes { get; set; }
    }
}
