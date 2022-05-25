using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            czyPierwsza();
        }
        static void NWD()
        {
            int a = 0, b = 0;

            Console.WriteLine("Wpisz a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWpisz b: ");
            b = Convert.ToInt32(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("\nWynik: " + a);
        }
        static void Pierwiastek()
        {
            double a = 0,  b = 0;

            Console.WriteLine("Wpisz a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWpisz b: ");
            b = Convert.ToInt32(Console.ReadLine());

            double wynik = Math.Pow(a, b);

            Console.WriteLine("\nWynik: " + wynik);
        }
        static void czyPierwsza()
        {
            double a = 0;

            Console.WriteLine("Wpisz a: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("\n" + a + " nie jest liczbą pierwszą");
                    break;
                }
                else
                {
                    Console.WriteLine("\n" + a + " jest liczbą pierwszą");
                    break;
                }
            }
            

        }
    }
}
