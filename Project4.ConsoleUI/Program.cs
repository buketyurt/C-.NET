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
            ProductManager productManager = new ProductManager(new EfProductDal());
            ProductManager productManager1 = new ProductManager(new ProductDal());

            List<Product> products = new List<Product>();
            List<Product> productsNames = new List<Product>();

            //products = productManager.GetById(4);
            //productsNames = productManager.GetByName("Mac X Bilgisayar");
            //Console.WriteLine(productManager.CalculateProfitById(5));
            //foreach (var product in productsNames)
            //{
            //    Console.WriteLine($"{product.ProductId} {product.ProductName} ");
            //    Console.WriteLine("---------------");
            //}
            //productManager.Remove(new Product
            //{
            //    ProductId = 78,
            //    ProductName = "Masa2",
            //    CategoryId = 2,
            //    QuantityPerUnit = "6 ayaklı Masa",
            //    UnitsInStock = 50,
            //    UnitPrice = 1000
            //});
            Console.WriteLine(productManager.GetById(1).ProductName);
            //productManager.Update(new Product
            //{
            //    ProductId = 78,
            //    ProductName = "Masa2",
            //    CategoryId = 2,
            //    QuantityPerUnit = "6 ayaklı Masa",
            //    UnitsInStock = 50,
            //    UnitPrice = 1000});

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            //try
            //{
            //    productManager.Add(new Product
            //    {
            //        ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "4 ayaklı Masa", UnitInStock = 50,
            //        UnitPrice = 1000
            //    });
            //}
            //catch (DuplicateProductException e)
            //{
            //    Console.WriteLine(e.Message);
            
            //}
            PersonalManager personalManager = new PersonalManager(new EfPersonalDal());
            foreach (var personel in personalManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.Name, personel.Surname);
            }
        }
    }
}
