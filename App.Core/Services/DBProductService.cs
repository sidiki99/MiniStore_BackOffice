using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace App.Core.Services
{
    public class DBProductService : IProductService
    {
        Product IProductService.Add(Product product)
        {
            throw new NotImplementedException();
        }

        bool IProductService.Delete(string id)
        {
            throw new NotImplementedException();
        }

        //List<Product> IProductService.GetAll()
        //{
        //    //throw new NotImplementedException();
        //    List<Product> products = new List<Product>();
        //    using(SqlConnection conn =  new SqlConnection(_connectionString)){
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "Select *  from Product";
        //        cmd.Connection = _connectionString;



        //    }
        //}


        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();

                    p.Id = reader["Id"].ToString();
                    p.Name = reader["Name"].ToString();
                    p.Price = Convert.ToDecimal(reader["Price"]);

                    products.Add(p);
                }
            }

            return products;
        }
        public DBProductService(string consString)
        {
            _connectionString = consString;

        }

        Product IProductService.GetById(string id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status)
        {
            // throw new NotImplementedException();
            return null;
        }

        bool IProductService.Update(Product product)
        {
            throw new NotImplementedException();
        }
        private readonly String _connectionString;
       
    }
}
