using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Bol(20,0));
        }
    }

    class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public decimal Bol(int a, int b){
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Catch çalıştı. Bir hata oluştu.");
                throw new DivideByZeroException("Sıfıra bölünemez.");
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("Catch çalıştı. Bir hata oluştu.");
                throw new DllNotFoundException();
            }
            catch (Exception exception)
            {
                Console.WriteLine("öngörülemeyen hata");
                Console.WriteLine(exception.InnerException);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
            }

        }
    }
}
