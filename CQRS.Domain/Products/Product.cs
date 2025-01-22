namespace CQRS.Domain.Products
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
