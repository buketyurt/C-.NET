using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Bussiness
{
    public class DuplicateProductException : Exception
    {
        public DuplicateProductException(string message) :base(message) //exceptionın da constroctur da çalıştır ve  e.MEssage denince de benim mesajım çalışcak
        {
            
        }
    }
}
