using System;

namespace Aula_07_11_2023_Exemplo02For
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;

            Console.Write("Informe o valor do fator: ");
            fator = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{fator} x {contador}  = {fator * contador}");
            }
        }
    }
}
