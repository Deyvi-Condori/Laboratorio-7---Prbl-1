using System;

namespace Secuencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            double sumaTotal = 0;

            for (int i = 1; i <= n; i++)
            {
                double resultado = (16.0 - i) / (3.0 * i);
                Console.WriteLine($"resultado : {resultado}");
                sumaTotal += resultado;
            }

            Console.WriteLine($"{sumaTotal}");
        }
    }
}
