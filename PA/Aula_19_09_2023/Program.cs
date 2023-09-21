using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            Console.Write("Informe sua 1° Nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Informe sua 2° Nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Informe sua 3° Nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Informe sua 4° Nota: ");
            n4 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media < 5)
            {
                Console.WriteLine("Reprovado! XD");
            }
            else if (media < 7)
            {
                Console.WriteLine("Recuperação! /:");
            }
            else
            {
                Console.WriteLine("Aprovado!! (:");
            }
            Console.WriteLine("Sua nota final é: " + media);
        }
    }
}