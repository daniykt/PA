using System;

namespace Aula_21_11_2023_Excer1
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float maxima = 0, minina = 0;

            for (int contador = 1; contador <= 15; contador++)
            {
                Console.Write("Digite uma altura: ");
                altura = float.Parse(Console.ReadLine());

                if (altura >= maxima)
                {
                    maxima = altura;

                }
                 else if (altura <= minina || minina ==0)
                {

                    minina = altura;
                }
            }

            Console.WriteLine($"Altura maxima: {maxima}");
            Console.WriteLine($"Altura minina: {minina}");
        }
    }
}
