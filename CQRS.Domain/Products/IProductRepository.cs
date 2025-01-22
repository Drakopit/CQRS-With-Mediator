namespace CQRS.Domain.Products
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task<int> AddAsync(Product product);
        Task<bool> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
    }
}
