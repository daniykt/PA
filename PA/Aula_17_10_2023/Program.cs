using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            float n1, n2;
            string operador;

            Console.Write("Informe 1° número: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Informe 2° número: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Informe o operador: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Resultado: {n1 + n2}");
                    break;

                case "-":
                    Console.WriteLine($"Resultado:  {n1 - n2}");
                    break;

                case "*":
                    Console.WriteLine($"Rsultado: {n1 * n2}");
                    break;

                case "/":
                    Console.WriteLine($"Resultado:{n1 / n2}");
                    break;

                default:
                    Console.WriteLine("Operador Inválido");
                    break;

            }
        }
    }
}
