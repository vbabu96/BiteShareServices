namespace BiteShare.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public string? ImageUrl { get; set; }
    public int LikesCount { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

}