﻿using System;

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
    }
}
