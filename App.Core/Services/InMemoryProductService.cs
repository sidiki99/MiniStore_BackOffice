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
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
        public bool Update(Product pro)
        {
            return false;
        }
        public bool Delete(string id)
        {
            return false;
        }
        public Product GetById(string id)
        { throw new NotImplementedException(); }
        public List<Product> GetAll()
        {
            return products.OrderBy(p => p.Name).ToList();
        }
      
        public List<Product> Search(string text, ProductCategoryEnum? category, ProductCategoryStatus status)
        {
            throw new NotImplementedException();
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

