using System;

namespace Aula_28_09_2023_revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, resultado;

            Console.Write("Informe 1° número: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Informe 2° número: ");
            n2 = float.Parse(Console.ReadLine());

            resultado = n1 + n2;
            Console.WriteLine($"Resultado da soma: {resultado}");

            resultado = n1 - n2;
            Console.WriteLine($"Resultado da subtração: {resultado}");

            resultado = n1 * n2;
            Console.WriteLine($"Resultado da multiplicação: {resultado}");

            resultado = n1 / n2;
            Console.WriteLine($"Resultado da divisão: {resultado}");

            
            
        }
    }
}
