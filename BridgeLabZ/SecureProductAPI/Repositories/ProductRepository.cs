using SecureProductAPI.Data;
using SecureProductAPI.Models;
using SecureProductAPI.Repositories.Interfaces;

namespace SecureProductAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll() => _context.Products.ToList();

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
