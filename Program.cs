using System;

namespace maior2ums
{
    class Program
    {
        static void Main(string[] args)
        {
            double comun,maior = 0;
        
            Console.Write("First number: ");
            comun = Convert.ToDouble(Console.ReadLine());

            if (comun > maior)
            {
                maior = comun;
            }

            Console.Write("Second number: ");
            comun = Convert.ToDouble(Console.ReadLine());

            if (comun > maior)
            {             
                maior = comun;
            }
             
            Console.Clear();
            Console.WriteLine($" = The largest number is = ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{maior}");
            Console.ResetColor();
            
        }
    }
}