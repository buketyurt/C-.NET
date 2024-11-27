using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread başladı. {Thread.CurrentThread.ManagedThreadId}");
            Process1Async();
            Process1Async(); Process1Async(); Process1Async(); Process1Async(); Process1Async(); Process1Async(); Process1Async(); Process1Async();
            Process2Async();
            Process1();
            Process2();

        }

        static  void Process1()
        {
            Console.WriteLine($" Senkron İşelm 1 başladı. {Thread.CurrentThread.ManagedThreadId}");
        }
        static async Task Process1Async() // nimetleri varmış
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Async İşlem 1 başladı. Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            });
        }
        static void Process2()
        {
            Console.WriteLine($"Senkron İşelm 2 başladı. {Thread.CurrentThread.ManagedThreadId}");
        }
        static async Task Process2Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Async İşlem 2 başladı. Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}
