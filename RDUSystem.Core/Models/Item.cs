namespace RDUSystem.Core.Models;

public class Item
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Unit { get; set; } = string.Empty;
    public int Quantity { get; set; } = 1;
    public double CostValue { get; set; }
    public double SaleMargin { get; set; }
    public double SaleValue { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; }
    
    public long CategoryId { get; set; }
    public ItemCategory Category { get; set; } = null!;
    
    public string UserId { get; set; } = string.Empty;
}