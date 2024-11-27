using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        //private List<Product> _products;
        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductId = 1, ProductName = "Acer ef Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 2, UnitPrice = 1000},
            //    new Product{ProductId = 2, ProductName = "Asus ef Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 1, UnitPrice = 1000},
            //    new Product{ProductId = 3, ProductName = "HP ef Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 0, UnitPrice = 1000},
            //    new Product{ProductId = 4, ProductName = "Mac ef Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 3, UnitPrice = 1000},
            //    new Product{ProductId = 5, ProductName = "Dell ef Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 10, UnitPrice = 1000},
            //};
        }

        public List<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList(); //garbage collectoru bekleme bellekten hızlıca sil
            }

        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductId == id); //garbage collectoru bekleme bellekten hızlıca sil
                //singleordefaultta eğer tek id düşmezse hata veriyor
                //firstordefault direkt ilkini veriyor
            }
        }

        public void Remove(Product product)//delete
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                context.SaveChanges();
            }
        }

        public Task<List<Product>> GetAllAsync()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Products.ToListAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Product product)
        {
            NorthwindContext context = new NorthwindContext();

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();

        }


        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
