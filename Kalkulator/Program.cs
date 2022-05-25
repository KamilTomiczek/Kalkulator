using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string znak;
            string end;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Wybierz co chcesz zrobić: ");
                Console.WriteLine("+ - dodawanie");
                Console.WriteLine("- - odejmowanie");
                Console.WriteLine("/ - dzielenie");
                Console.WriteLine("* - mnożenie");
                Console.WriteLine("n - NWD");
                Console.WriteLine("^ - potęga");
                Console.WriteLine("v - pierwiastek");

                znak = "";

                znak = Console.ReadLine();

                Console.Clear();

                if(znak == "+")
                {
                    Dodawanie();
                }
                else if(znak == "-")
                {
                    Odejmowanie();
                }
                else if (znak == "*")
                {
                    Mnozenie();
                }
                else if (znak == "/")
                {
                    Dzielenie();
                }
                else if (znak == "n")
                {
                    NWD();
                }
                else if (znak == "^")
                {
                    Potega();
                }
                else if (znak == "v")
                {
                    czyPierwsza();
                }
                else
                {
                    Console.WriteLine("\nBłędny znak");
                }

                end = "";

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Czy zakończyc program(t/n)");
                end = Console.ReadLine();

                if(end == "t")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        static void Dodawanie()
        {
            Console.WriteLine("Wpisz a: ");
            double a = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("\nWpisz b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double w = a + b;

            Console.WriteLine("\nWynik: " + w);
        }

        static void Odejmowanie()
        {
            Console.WriteLine("Wpisz a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWpisz b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double w = a - b;

            Console.WriteLine("\nWynik: " + w);
        }

        static void Mnozenie()
        {
            Console.WriteLine("Wpisz a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWpisz b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double w = a * b;

            Console.WriteLine("\nWynik: " + w);
        }

        static void Dzielenie()
        {
            Console.WriteLine("Wpisz a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWpisz b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("\nNie dziel przez zero");
            }
            else
            {
                double w = a / b;

                Console.WriteLine("\nWynik: " + w);
            }

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

        static void Potega()
        {
            double a = 0,  b = 0;

            Console.WriteLine("Wpisz a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nWpisz b: ");
            b = Convert.ToDouble(Console.ReadLine());

            double wynik = Math.Pow(a, b);

            Console.WriteLine("\nWynik: " + wynik);
        }

        static void czyPierwsza()
        {
            double a = 0;

            Console.WriteLine("Wpisz a: ");
            a = Convert.ToDouble(Console.ReadLine());

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

        static void pierwiastek()
        {
            Console.WriteLine("Wpisz a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nWynik: " + Math.Sqrt(a));
        }
    }
}
