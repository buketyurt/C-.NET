using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    //class demek referance type olmak demek, interfaceler newlenemediği için new() koyduk
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> GetByName(string name);
        void Add(T product);
        
        void Update(T product);
        void Remove(T product);
    }
}
