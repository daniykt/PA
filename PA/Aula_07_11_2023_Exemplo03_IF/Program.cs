using System;

namespace Aula_07_11_2023_Exemplo03_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite o Número desejado: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par [: ");
            else
                Console.WriteLine("O número é impar :)"); 

        }
    }
}
