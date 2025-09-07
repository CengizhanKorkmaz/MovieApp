using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Domain.Entities;

namespace MovieApp.Persistence.Data.Mappings;

public class RelatedMovieMapping:IEntityTypeConfiguration<RelatedMovie>
{
    public void Configure(EntityTypeBuilder<RelatedMovie> builder)
    {
        builder.ToTable("RelatedMovies");
        builder.HasKey(rm => rm.Id);
    }
}