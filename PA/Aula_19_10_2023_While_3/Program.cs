﻿using System;

namespace Aula_19_10_2023_While_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;

            Console.Write("Informe o fator: ");
            fator = int.Parse(Console.ReadLine());
           
            int final;

            Console.Write("Informe o N° Final: ");
            final = int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador <= final)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                contador++;
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}
