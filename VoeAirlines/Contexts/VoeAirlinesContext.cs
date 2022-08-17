using Microsoft.EntityFrameworkCore;
using VoeAirlines.Entities;

namespace VoeAirlines.Contexts
{
    
    public class VoeAirlinesContext : DbContext
    {
        
        public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
        public DbSet<Cancelamento> Cancelamentos => Set<Cancelamento>();
        public DbSet<Manutencao> Manutencoes => Set<Manutencao>();
        public DbSet<Piloto> Pilotos => Set<Piloto>();
        public DbSet<Voo> Voos => Set<Voo>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer("Password=teste*123;Persist Security Info=True;User ID=sa;Initial Catalog=master;Data Source=Lab206_17");
        }
    }
}
