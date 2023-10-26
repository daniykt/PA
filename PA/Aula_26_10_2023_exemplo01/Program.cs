using System;

namespace Aula_26_10_2023_exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            do
            {
                Console.WriteLine($"2 x {contador} = {2 * contador}");
                contador++;
            } while (contador <= 10);
        }
    }
}
