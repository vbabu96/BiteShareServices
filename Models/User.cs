using Microsoft.AspNetCore.Identity;

namespace BiteShare.Models;

public class User : IdentityUser
{
    public string? Name { get; set; }
    public string? ProfilePicture { get; set; }
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}