using StoreManagementSystem.Models;

namespace StoreManagementSystem.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;

        public ProductService()
        {
            _products.Add(new Product { Id = _nextId++, Name = "Laptop", Price = 1200.00M, Quantity = 5 });
        }

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }

        public bool Update(int id, Product updatedProduct)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Name = updatedProduct.Name;
            existing.Price = updatedProduct.Price;
            existing.Quantity = updatedProduct.Quantity;
            return true;
        }

        public bool Delete(int id)
        {
            var product = GetById(id);
            if (product == null) return false;

            _products.Remove(product);
            return true;
        }
    }
}

