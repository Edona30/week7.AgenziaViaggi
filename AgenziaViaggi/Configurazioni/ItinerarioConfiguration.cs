using AgenziaViaggi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi
{
    internal class ItinerarioConfiguration : IEntityTypeConfiguration<Itinerario>
    {
        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.HasMany(g => g.Gite).WithOne(i => i.Itinerario).HasForeignKey(g =>g.GitaID);
            builder.ToTable("Itinerario");
            builder.HasKey(e => e.ItinerarioID);
            builder.Property(e => e.Descrizione).HasMaxLength(200).IsRequired();

        }
    }
}