using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            NWD();
            Pierwiastek();
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
    }
}
