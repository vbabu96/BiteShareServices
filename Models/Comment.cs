namespace BiteShare.Models;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}