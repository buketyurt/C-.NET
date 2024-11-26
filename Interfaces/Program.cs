using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface newlenemez
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
        }

        //class PersonManager
        //{
        //    //implemented operation
        //    public void Add()
        //    {
        //        Console.WriteLine("Eklendi");
        //    }
        //}

        //class CustomerManager : PersonManager
        //{

        //}
        interface IPersonManager
        {
            //implemented operation
            public void Add();
            public void Update();

        }
        //classlarda inherits - interfacede implements
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                //müşterieklemekodları
                Console.WriteLine("Müşteri Eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri Güncellendi");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                //personel ekleme
                Console.WriteLine("personel eklendi");
            }
            public void Update()
            {
                Console.WriteLine("Personel Güncellendi");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                
                personManager.Add();


            }

        }

    }
}
