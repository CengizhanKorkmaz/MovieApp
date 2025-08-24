using Microsoft.EntityFrameworkCore;
using MovieApp.Domain.Entities;
using MovieApp.Persistence.Data.Mappings;

namespace MovieApp.Persistence.Data.Context;

public class ApplicationContext:DbContext
{
    public ApplicationContext()
    {
        
    }
    public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
    {
        
    }
    
    
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
         optionsBuilder.UseSqlServer("Server=localhost,1433;Database=MovieAppDb;User Id=sa;Password=369568C.k;TrustServerCertificate=True;");
   }
   public DbSet<Cast> Casts { get; set; }
   public DbSet<Category> Categories { get; set; }
   public DbSet<Movie> Movies { get; set; }
   public DbSet<Review> Reviews { get; set; }
   public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CastMapping());
        modelBuilder.ApplyConfiguration(new CategoryMapping());
        modelBuilder.ApplyConfiguration(new MovieMapping());
        modelBuilder.ApplyConfiguration(new ReviewMapping());
        modelBuilder.ApplyConfiguration(new TagMapping());
        
        base.OnModelCreating(modelBuilder);
    }
   
}