using AgenziaViaggi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi
{
    internal class PartecipanteConfiguration : IEntityTypeConfiguration<Partecipante>
    {
        public void Configure(EntityTypeBuilder<Partecipante> builder)
        {
            builder.HasMany(g => g.Gite).WithMany(g => g.Partecipanti);
            builder.ToTable("Partecipante");
            builder.HasKey(e => e.PartecipanteID);
            
        }
    }
}