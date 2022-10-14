using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Classes;

namespace ProjetoWeb.Models
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco(DbContextOptions<ContextoBanco> options) : base(options) { }

        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }

    }
}
