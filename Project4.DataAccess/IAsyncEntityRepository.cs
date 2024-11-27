using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Entities;

namespace Project4.DataAccess
{
    public interface IAsyncEntityRepository<T> where T : class , IEntity, new()
    {

            Task<List<T>> GetAllAsync();
            Task<T> GetByIdAsync(int id);
            Task<List<T>> GetByNameAsync(string name);
            Task AddAsync(T product);

            Task UpdateAsync(T product);
            Task RemoveAsync(T product);
        
    }
}
