using Project4.Bussiness;
using Project4.DataAccess;
using System;
using System.Collections.Generic;
using Project4.Entities;

namespace Project4.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new XProductDal());
            ProductManager productManager1 = new ProductManager(new ProductDal());

            List<Product> products = new List<Product>();
            List<Product> productsNames = new List<Product>();

            products = productManager.GetById(4);
            productsNames = productManager.GetByName("Mac X Bilgisayar");
            Console.WriteLine(productManager.CalculateProfitById(5));
            foreach (var product in productsNames)
            {
                Console.WriteLine($"{product.ProductId} {product.ProductName} ");
                Console.WriteLine("---------------");
            }

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
