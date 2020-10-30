using System;
using Figgle;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double comun,maior = 0;
        
            Console.Write("Primeiro numero: ");
            comun = Convert.ToDouble(Console.ReadLine());

            if (comun > maior)
            {
                maior = comun;
            }

            Console.Write("Segundo numero: ");
            comun = Convert.ToDouble(Console.ReadLine());

            if (comun > maior)
            {             
                maior = comun;
            }
             
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(FiggleFonts.Banner3.Render($"{maior}"));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|Numero maior|");
            Console.ResetColor();
            
            
        }
    }
}