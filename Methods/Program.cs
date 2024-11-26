using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            int sonuc = matematik.Toplama(2,3);
            int sonuc2 = matematik.Toplama(2);
            int sonuc3 = matematik.Toplama(23, 4, 4);
            int sonuc4 =matematik.ToplaParams(new int[] { 2, 3, 4, 5, 6, 4 });
            int sonuc5 = matematik.ToplaParams(2, 3, 4, 5, 6, 6, 7, 8, 3);
        }
    }
    //overloading
    class Matematik
    {
        public int Toplama(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Toplama(int a, int b = 200)
        {
            return a + b;
        }

        public int ToplaParams(params int[] sayilar)
        {
            int sonuc = 0;
            //foreach (var sayi in sayilar)
            //{
            //    sonuc += sayi;
            //}

            return sayilar.Sum();
        }
        public int Cikarma(int a, int b = 200)
        {
            return a - b;
        }
    }
}
