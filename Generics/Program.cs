using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("buket");
            sehirler.Add("buket");
            sehirler.Add("buket");
            sehirler.Add("buket");
            sehirler.Add("buket");
            sehirler[0] = "İstanbul";//set
            Console.WriteLine(sehirler[0]);//get
            Console.WriteLine(sehirler.Count); //property bu, method olsaydı () olurudu sonunda

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("buket");
            sehirler2.Add("buket");
            sehirler2.Add("buket");
            sehirler2.Add("buket");
            sehirler2[0] = "İstanbul";
            //indexing

            Console.WriteLine(sehirler2.Count);
            Console.WriteLine(sehirler2[0]);//get
            foreach (var sehir in sehirler2.Items)
            {
                Console.WriteLine(sehir);
            }
        }
    }

    class MyList<T>
    {
        private T[] _array;
        private T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length -1 ]= item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get
            {
                return _array;
            }
        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
    }
    
}
