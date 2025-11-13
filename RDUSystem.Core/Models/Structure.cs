namespace RDUSystem.Core.Models;

public class Structure
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int Quantity { get; set; } = 1;
    public double CostValue { get; set; }
    public double SaleMargin { get; set; }
    public double SaleValue { get; set; }
    
    public List<Item> Items { get; set; } = null!;
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; }
    
    public string UserId { get; set; } = string.Empty;
    public string CustomerId { get; set; } = string.Empty;
}