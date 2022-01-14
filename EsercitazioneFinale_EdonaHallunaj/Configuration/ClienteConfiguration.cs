using EsercitazioneFinale_EdonaHallunaj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsercitazioneFinale_EdonaHallunaj
{
    internal class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(k => k.CodiceFiscale);
            builder.Property(k => k.CodiceFiscale).HasMaxLength(16);
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Cognome).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Indirizzo).HasMaxLength(50).IsRequired();
        }
    }
}