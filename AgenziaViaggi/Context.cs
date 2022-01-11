using AgenziaViaggi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi
{
    public class Context : DbContext 
    {
        public DbSet<Partecipante> Partecipanti { get; set; }
        public DbSet<Gita> Gite { get; set; }
        public DbSet<Responsabile> Responsabili { get; set; }
        public DbSet<Itinerario> Itinerari { get; set; }

        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgenziaViaggi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Partecipante>(new PartecipanteConfiguration());
            modelBuilder.ApplyConfiguration<Gita>(new GitaConfiguration());
            modelBuilder.ApplyConfiguration<Responsabile>(new ResponsabileConfiguration());
            modelBuilder.ApplyConfiguration<Itinerario>(new ItinerarioConfiguration());

          
        }
    }
}
