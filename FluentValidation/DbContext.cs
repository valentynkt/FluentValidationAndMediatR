public static class DbContext
{
    public static List<Product> Products { get; set; } = new List<Product>
    {
        new Product { Id = 1, CategoryId = 1, Name = "Product1", Price = 100, CreatedAt = DateTime.Now, IsActive = true },
        new Product { Id = 2, CategoryId = 1, Name = "Product2", Price = 200, CreatedAt = DateTime.Now, IsActive = true },
        new Product { Id = 3, CategoryId = 2, Name = "Product3", Price = 300, CreatedAt = DateTime.Now, IsActive = true },
        new Product { Id = 4, CategoryId = 2, Name = "Product4", Price = 400, CreatedAt = DateTime.Now, IsActive = true },
    };

    public static List<Category> Categories { get; set; } = new List<Category>
    {
        new Category { Id = 1, Name = "Category1", CreatedAt = DateTime.Now, IsActive = true },
        new Category { Id = 2, Name = "Category2", CreatedAt = DateTime.Now, IsActive = true },
    };
    public static async Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        // add async product to db
        Products.Add(product);
    }
    public static List<Product> GetProducts()
    {
        return Products;
    }

    public static List<Category> GetCategories()
    {
        return Categories;
    }
}
