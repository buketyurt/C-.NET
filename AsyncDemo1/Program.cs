
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(($"Thread No : {Thread.CurrentThread.ManagedThreadId}"));
          /*  Task task1 = new Task(Process1); 
            task1.Start();
            Process2();*/ 

            /*Console.WriteLine("1. İşleme Başladı"); Process1();

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("2. İşmleme başladı");Process2();*/

            //Console.ReadKey();
            //Task task1 = Task.Factory.StartNew(Process1); //Task task1 = new Task(Process1);  -> bu kod bloğunun kısa hali
                                                          // task1.Start();
          //  Task task1 = Task.Run(Process1);

          /*  Task task1 = Task.Run(() => //-> async olarak çalıştı 
            {
                Process1();
                Process2();
            });*/
          Task task1 = Task.Run(Process1);
          task1.Wait(); //WAIT! THEY DONT LIKE YOU LIKE ILOVE U!!!! WAAAAAAIIIITTTT  (EH ANLADIM)
          Process2();

        }

        static void Process1()
        {
            Console.WriteLine("1. İşleme başladım");
            Console.WriteLine(($"Thread No : {Thread.CurrentThread.ManagedThreadId}"));

        }
        static void Process2()
        {
            Console.WriteLine("2. İşleme başladım");
            Console.WriteLine(($"Thread No : {Thread.CurrentThread.ManagedThreadId}"));

        }
    }
}
