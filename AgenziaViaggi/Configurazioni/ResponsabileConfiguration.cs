using AgenziaViaggi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggi
{
    internal class ResponsabileConfiguration : IEntityTypeConfiguration<Responsabile>
    {
        public void Configure(EntityTypeBuilder<Responsabile> builder)
        {
            builder.HasMany(g => g.Gite).WithOne(r => r.Respondabile).HasForeignKey(g => g.GitaID); ;
            builder.ToTable("Responsabile");
            builder.HasKey(e => e.RespondabileID);
            builder.Property(e => e.NumerodiTelefono).HasMaxLength(10).IsRequired();
        }
    }
}