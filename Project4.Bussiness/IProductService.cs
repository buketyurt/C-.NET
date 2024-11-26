using System.Collections.Generic;
using Project4.Entities;

namespace Project4.Bussiness
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        List<Product> GetById(int id);
        decimal CalculateProfitById(int id);
    }
}