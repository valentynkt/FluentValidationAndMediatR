public enum ProductRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

public class Product
{
    public int Id { get; set; } // Primary key

    public int CategoryId { get; set; } // Foreign key

    // Other product fields
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    // Navigation property
    public Category Category { get; set; }
}
