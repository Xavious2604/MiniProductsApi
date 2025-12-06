using MiniProductsApi.Models;

namespace MiniProductsApi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 55000 },
            new Product { Id = 2, Name = "Mouse", Price = 500 }
        };

        public IEnumerable<Product> GetAll() => _products;
        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product Add(Product p)
        {
            p.Id = _products.Max(x => x.Id) + 1;
            _products.Add(p);
            return p;
        }

        public bool Update(int id, Product updated)
        {
            var p = GetById(id);
            if (p == null) return false;

            p.Name = updated.Name;
            p.Price = updated.Price;
            return true;
        }

        public bool Delete(int id)
        {
            var p = GetById(id);
            return p != null && _products.Remove(p);
        }
    }
}
