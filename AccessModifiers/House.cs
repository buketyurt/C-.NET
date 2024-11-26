using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //internal -> belirli namespace'de çalışan
    //property'nin defaultu private
    //privat sadece ve sadece kendi classı ama protected kendi claası ve classı inherit edenlerde
    public class House
    {
        public int Id { get; set; }
        public string City { get; set; }
        protected string Suburb { get; set; }
    }
}
