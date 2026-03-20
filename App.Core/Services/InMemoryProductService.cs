using App.Core.Contracts;
using App.Core.Models;
using App.Core.Services;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App.Core.Services
{
    public class InMemoryProductService : IProductService 
    {
        private List<Product> products;
        public InMemoryProductService()
        {
            products = new List<Product>();
            GenerateFakeProducts();
        }
        public Product Add(Product product)
        {
            if(product != null)
            {
                product.Id = GenerateId();
                products.Add(product);

            }
            return product;

        }
        public bool Update(Product product) { 
            if( product != null)
        {
                Product? existing = products.Find(p => p.Id == product.Id);
                if (existing == null) return false;
                existing.Name = product.Name;
                existing.Category = product.Category;
                existing.Price = product.Price;
                existing.Status = product.Status;
                existing.Stock = product.Stock;
                
           
        }
            return true;
        }
        public bool Delete(string id)
        {
            Product prodToBeDeleted = GetById(id);
            products.Remove(prodToBeDeleted);
            return true;
        }
        public Product? GetById(string id)
        {
            Product? prod = products.Find(p => p.Id == id);
            return prod;
        }
        public List<Product> GetAll()
        {
            return products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status)
        {
            List<Product> _filtered = products.ToList();

            if (!string.IsNullOrEmpty(text))
                _filtered = _filtered.Where(p => p.Name.Contains(text)).ToList();

            if (category != null)
                _filtered = _filtered.Where(p => p.Category == category).ToList();

            if (status != null)
                _filtered = _filtered.Where(p => p.Status == status).ToList();

            return _filtered;
        }
        public void GenerateFakeProducts()
        {
            products.Clear();
            products.Add(new Product
            {
                Id =GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 1500000.00m,
                Stock = 10,
                Status =ProductCategoryStatus.Active

            });
            products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Smartphone",
                Category = ProductCategoryEnum.Clothing,
                Price = 800000.00m,
                Stock = 25,
                Status = ProductCategoryStatus.Active
            });

            products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Office Chair",
                Category = ProductCategoryEnum.Electronics,
                Price = 45000.00m,
                Stock = 15,
                Status = ProductCategoryStatus.Active
            });
            


        }
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }


    }
}

