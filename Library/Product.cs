namespace Library;
public record Product
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public string FullDescription => $"{Name} - {Description}";
    public decimal Tax => Price * (decimal) 0.19;
}
 