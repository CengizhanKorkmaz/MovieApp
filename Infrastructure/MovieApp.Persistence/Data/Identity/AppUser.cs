using Microsoft.AspNetCore.Identity;

namespace MovieApp.Persistence.Data.Identity;

public class AppUser:IdentityUser
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? ImageUrl { get; set; }
    
}