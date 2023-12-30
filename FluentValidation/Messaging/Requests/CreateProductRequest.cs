namespace FluentValidationTest.Messaging.Requests
{
    public class CreateProductRequest
    {
        public int CategoryId { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

    }
}
