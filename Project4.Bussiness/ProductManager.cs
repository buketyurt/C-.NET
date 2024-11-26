using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Bussiness
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("Laptop ekleyemezsiniz.");
            }
            _productDal.Add(product);
        }

        public List<Product> GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public decimal CalculateProfitById(int id)
        {
            Product product = _productDal.GetById(id).FirstOrDefault();
            decimal result = product.UnitInStock * product.UnitPrice;
            return result;
        }

        public List<Product> GetByName(string name)
        {
            return _productDal.GetByName(name);
        }

        public List<Product> GetAll()
        {
            
            //iş kodları yazılır
            return _productDal.GetAll();
        }

    }
}
