using System.Collections.Generic;
using Project4.Entities;

namespace Project4.Bussiness
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Remove(Product  product);
        void Update (Product product);
        decimal CalculateProfitById(int id);
    }
}