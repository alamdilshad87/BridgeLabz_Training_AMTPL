using SecureProductAPI.Models;

namespace SecureProductAPI.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
