using System;

namespace aula_14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4, media;

            Console.Write("Informe o número 01: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o número 02: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o número 03: ");
            n3 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o númeo 04: ");
            n4 = decimal.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Outras formas
            Console.WriteLine("A média: " + media);

            Console.WriteLine("A média: " + (n1 + n2 + n3 + n4) / 4);

            Console.WriteLine($"A média: {media}");
        }
    }
}
