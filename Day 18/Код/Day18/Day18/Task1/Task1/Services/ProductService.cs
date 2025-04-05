using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Models;

namespace Task1.Services
{
    public class ProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            // Initialize with sample data
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Quantity = 5, Category = "Electronics", Price = 999.99m, MinimumStock = 3 },
                new Product { Id = 2, Name = "Mouse", Quantity = 15, Category = "Electronics", Price = 29.99m, MinimumStock = 5 },
                new Product { Id = 3, Name = "Keyboard", Quantity = 2, Category = "Electronics", Price = 49.99m, MinimumStock = 4 },
                new Product { Id = 4, Name = "Monitor", Quantity = 8, Category = "Electronics", Price = 299.99m, MinimumStock = 3 },
                new Product { Id = 5, Name = "Headphones", Quantity = 1, Category = "Electronics", Price = 79.99m, MinimumStock = 5 }
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products.ToList();
        }

        public void UpdateStock(int productId, int newQuantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                product.Quantity = newQuantity;
            }
        }

        public void SimulateStockUpdate()
        {
            Random random = new Random();
            foreach (var product in _products)
            {
                product.Quantity = random.Next(0, 20);
            }
        }
    }
} 