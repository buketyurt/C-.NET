using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara", Email = "engin@"},
                new Customer{Id = 2, FirstName = "Derin", LastName = "Demiroğ", City = "Ankara", Email = "derin@"},
                new Customer{Id = 3, FirstName = "Salih", LastName = "Demiroğ", City = "Ankara", Email = "salih@"},
                new Customer{Id = 3, FirstName = "Mehmet", LastName = "Demiroğ", City = "İstanbul", Email = "ahmet@"},
                new Customer{Id = 5, FirstName = "Mehmet", LastName = "Demiroğ", City = "İzmir", Email = "mehmet@"}

            };
        }
        private List<Customer> customers;
        public List<Customer> GetAll()
        {
            
            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public List<Customer> GetFindByName(string name)
        {
         List<Customer> customers2 = new List<Customer>();
       
            foreach (var customer in customers)
            {
                if (customer.FirstName == name)
                {
                    customers2.Add(customer);
                }
            }

            return customers2;
        }

        public Customer GetFindById(int id)
        {
            return customers.FirstOrDefault(p => p.Id == id);
        }
    }
}
