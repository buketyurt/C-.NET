using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EfPersonalDal : IPersonelDal
    {
        public void Add(Personel product)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Personels.ToList();
            }
        }

        public Personel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Personel product)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel product)
        {
            throw new NotImplementedException();
        }
    }
}
