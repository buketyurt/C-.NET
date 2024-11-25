using Project4.Bussiness;
using Project4.DataAccess;
using System;
using Project4.Entities;

namespace Project4.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new XProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            try
            {
                productManager.Add(new Product
                {
                    ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "4 ayaklı Masa", UnitInStock = 50,
                    UnitPrice = 1000
                });
            }
            catch (DuplicateProductException e)
            {
                Console.WriteLine(e.Message);
            
            }
        }
    }
}
