 using System;
 using System.Collections.Generic;
 using System.Linq;

 namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{CategoryId = 1, ProductId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 5},
                new Product{CategoryId = 1, ProductId = 2, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 8000, UnitsInStock = 3},
                new Product{CategoryId = 1, ProductId = 3, ProductName = "HP Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6000, UnitsInStock = 2},
                new Product{CategoryId = 2, ProductId = 4, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitsInStock = 15},
                new Product{CategoryId = 2, ProductId = 5, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitsInStock = 0},
            };
            //Test(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);
            //ClassicLnqTest(products);
            var result = from p in products
                join c in categories on p.CategoryId equals c.CategoryId
                         where p.UnitPrice >5000 orderby p.UnitPrice descending 
                select new ProductDto{ProductName = p.ProductName, ProductId = p.ProductId,  UnitPrice = p.UnitPrice, CategoryName = c.CategoryName};
            foreach (var productDto in result)
            {
             Console.WriteLine(productDto.ProductName + " "+ productDto.CategoryName);   
            }
        }

        private static void ClassicLnqTest(List<Product> products)
        {
            var result = from p in products where p.UnitPrice>6000 orderby p.UnitPrice descending select new ProductDto{ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice};
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result= products.Where(p => p.ProductName.Contains("top")).OrderByDescending( p=>p.UnitPrice);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result =products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result =products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritma");
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitsInStock > 2)
                {
                    Console.WriteLine(item.ProductName);
                }

            }
            Console.WriteLine("Linq");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 2);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var item in products)
            {
                
                if (item.UnitPrice > 5000 && item.UnitsInStock > 2)
                {
                    filteredProduct.Add(item);
                }

            }
            return filteredProduct;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 2).ToList();
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
