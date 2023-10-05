using System;

namespace aula_05_10_2023_atividdade
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

            if (operador == "+")
            Console.WriteLine($"Resultado: {n1 + n2}");

            else if (operador == "-") 
            Console.WriteLine($"Resultado:  {n1 - n2}");

            else if (operador == "*") 
            Console.WriteLine($"Rsultado: {n1 * n2}");

            else
                Console.WriteLine($"Resultado:{n1 / n2}");



        }
    }
}
