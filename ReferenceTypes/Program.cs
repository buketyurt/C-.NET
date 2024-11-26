using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10; int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine(sayi1);

            ////array tipleri reference type - heap'de tutuluyor
            //int[] sayilar = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] {10,20,30 };

            //sayilar = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine(sayilar[0]);

            Person person = new Person();
            Person person2 = new Person();

            person.FirstName = "Engin";
            person2 = person;
            person.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = 736823686;
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            //Console.WriteLine(customer.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
        }
    }
    //base class
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public int CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
