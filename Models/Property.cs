namespace EstateFlow.Models;

public class Property
{
    public int PropertyId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string PropertyType { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Status { get; set; } = "Available";
    public DateTime CreatedAt { get; set; }
}
