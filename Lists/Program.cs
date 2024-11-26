using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler.Length);

            sehirler = new string[4];
            sehirler[3] = "Bursa";
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            List<string> sehirler2 = new List<string>(){ "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Bursa");
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }

            sehirler2.Remove("İstanbul");
            bool sonuc = sehirler2.Contains("İzmir");
        }
    }
}
