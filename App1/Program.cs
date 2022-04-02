
using System;
using System.Collections.Generic;

namespace uri1145
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediana = 0;
            double soma = 0;
            for (int i = 0; i < 5; i++)
            {
                double var = double.Parse(Console.ReadLine());
                soma = soma + var;
                if(i == 0 && var >= 9)
                {
                }
                if(i == 1 && var <= 9 && var >= 7.5)
                {
                }
                if (i == 2 && var >= 6 && var < 7.5)
                {
                    mediana = var;
                }
                if (i == 3 && var >= 4 && var < 6)
                {
                }
                else
                {
                }
            }
            double média = soma / 5;
            Console.WriteLine("A média é: " + média);
            Console.WriteLine("A mediana é: " + mediana);
        }
    }
}
