using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class ProductDal : IProductDal
    {
        private List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, ProductName = "Acer Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitsInStock = 2, UnitPrice = 1000},
                new Product{ProductId = 2, ProductName = "Asus Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitsInStock = 1, UnitPrice = 1000},
                new Product{ProductId = 3, ProductName = "HP Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitsInStock = 0, UnitPrice = 1000},
                new Product{ProductId = 4, ProductName = "Mac Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitsInStock = 3, UnitPrice = 1000},
                new Product{ProductId = 5, ProductName = "Dell Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitsInStock = 10, UnitPrice = 1000},
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile eklendi.");
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
