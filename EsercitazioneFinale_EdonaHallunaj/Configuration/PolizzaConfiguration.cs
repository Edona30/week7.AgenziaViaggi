using EsercitazioneFinale_EdonaHallunaj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsercitazioneFinale_EdonaHallunaj
{
    internal class PolizzaConfiguration : IEntityTypeConfiguration<Polizza>
    {
        public void Configure(EntityTypeBuilder<Polizza> builder)
        {
            builder.ToTable("Polizza");
            builder.HasKey(x => x.Numero);
            

            //Gestire Ereditarietà
            builder.HasDiscriminator<string>("Type").HasValue<Polizza>("polizza").HasValue<RCAuto>("RCauto").HasValue<Vita>("vita").HasValue<Furto>("furto");



        }
    }
}