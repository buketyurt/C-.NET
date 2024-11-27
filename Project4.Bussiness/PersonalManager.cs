using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.DataAccess;
using Project4.Entities;

namespace Project4.Bussiness
{
    public class PersonalManager :IPersonalService
    {
         IPersonelDal _personelDal;
         public PersonalManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
