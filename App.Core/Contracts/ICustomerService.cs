using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface ICustomerService
    {

        List<Customer>GetAll();
        Customer GetById(string id);
        void  Add(Customer customer);
        void Update(Customer customer);
       void  Delete(string id);
        
        

        //Order PlaceOrder(Order order, List<OrderItem> items);
        //List<Order> GetCustomerOrders(string customerId);

        
        List<Customer> Search(string query);
    }
}