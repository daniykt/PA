using System;

namespace Aula_14_11_2023_execicios_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int subtracao1, subtracao2;


            for (int contador = 1; contador <= 3; contador++) 
            {
                Console.Write("Digite o Primeiro número: ");
                subtracao1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o Segundo número: ");
                subtracao2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"O Resultado: {subtracao1 - subtracao2}");
            }
        }
    }
}
