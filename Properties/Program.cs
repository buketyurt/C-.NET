using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1; //setter çalışıyor
            Console.WriteLine(product.Id); //getter çalıştı
            product.UnitsInStock = 50;
            Console.WriteLine(product.UnitsInStock);
            product.UnitPrice = 500;
            Console.WriteLine(product.UnitPrice);
        }
    }

    class Product
    {
        //field
        private decimal _unitprice;
        public int Id { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice
        {
            get { return _unitprice + _unitprice * 18 / 100; }
            set { _unitprice = value; }
        }
        public decimal UnitsInStock { get; set; }
    }
}
