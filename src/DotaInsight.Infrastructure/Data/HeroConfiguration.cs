using DotaInsight.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DotaInsight.Infrastructure.Data;

public class HeroConfiguration : IEntityTypeConfiguration<Hero>
{
    public void Configure(EntityTypeBuilder<Hero> builder)
    {
        builder.ToTable("Heroes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}