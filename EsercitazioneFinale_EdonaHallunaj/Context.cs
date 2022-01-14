using EsercitazioneFinale_EdonaHallunaj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale_EdonaHallunaj
{
    internal class Context : DbContext
    {
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Polizza> Polizze { get; set; }
        public DbSet<RCAuto> PolizzeRCAuto { get; set; }
        public DbSet<Vita> PolizzeVita { get; set; }
        public DbSet<Furto> PolizzeFurto { get; set; }


        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EsercitazioneFinaleEdona;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<Polizza>(new PolizzaConfiguration());

        }
    }
}
