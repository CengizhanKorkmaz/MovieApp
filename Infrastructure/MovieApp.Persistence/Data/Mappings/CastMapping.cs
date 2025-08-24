using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Domain.Entities;

namespace MovieApp.Persistence.Data.Mappings;

public class CastMapping:IEntityTypeConfiguration<Cast>
{
    public void Configure(EntityTypeBuilder<Cast> builder)
    {
        builder.ToTable("Casts");
        builder.HasKey(c => c.Id);
    }
}