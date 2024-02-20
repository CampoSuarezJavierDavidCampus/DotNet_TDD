using System.Diagnostics.CodeAnalysis;

namespace API.Models;

[ExcludeFromCodeCoverage]
public class User
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string LastName { get; set; }
    public string? Phone { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;
    public bool IsActived { get; set; }
}
