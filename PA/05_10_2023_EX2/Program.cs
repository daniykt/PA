using System;

namespace _05_10_2023_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.Write("Informe o 1° número: ");
            n1 = int.Parse(Console.ReadLine());


            if (n1 < 10)
                Console.WriteLine("Número maior do que 10");
            
            else
                 Console.WriteLine("Número menor do que 10");

        }
    }
}
