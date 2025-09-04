namespace MovieApp.Dto.Dtos.Movies;

public class GetAllMovieDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string CoverImageUrl { get; set; }
    public decimal Rating { get; set; }
    public string? Description { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Year { get; set; }
    public bool Status { get; set; }
}