using System;

namespace Classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(){ProductName = "laptop", UnitInStock = 5, UnitPrice = 5000};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
