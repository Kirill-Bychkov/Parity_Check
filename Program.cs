using System;

namespace Parity_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a;
            string b = Console.ReadLine();
            try
            {
                a = Convert.ToDouble(b);
                if (a % 2 == 0)
                {
                    Console.WriteLine("Число " + a + " четное");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Число " + a + " нечетное");
                    Console.ReadKey();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка, введено не число");
                Console.ReadKey();
            }

            
        }
    }
}
