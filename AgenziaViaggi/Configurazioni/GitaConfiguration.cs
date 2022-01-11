using AgenziaViaggi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi
{
    internal class GitaConfiguration : IEntityTypeConfiguration<Gita>
    {
        public void Configure(EntityTypeBuilder<Gita> builder)
        {
            builder.HasMany(g => g.Partecipanti).WithMany(g => g.Gite);
            builder.HasOne(r => r.Respondabile).WithMany(g => g.Gite).HasForeignKey(r =>r.ResponsabileID);
            builder.HasOne(i => i.Itinerario).WithMany(g => g.Gite).HasForeignKey(i =>i.ItinerarioID);

            builder.ToTable("Gita");
            builder.HasKey(e => e.GitaID);
        }

        
    }
}