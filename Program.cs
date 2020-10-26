using System;
using System.Runtime.InteropServices;

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
            
            Console.WriteLine($"The largest number is: {maior}");
            
        }
    }
}