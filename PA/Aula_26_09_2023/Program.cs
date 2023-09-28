using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, percFreg;

            Console.Write("Informe sua 1° Nota: ");
            n1 = float.Parse(Console.ReadLine());
            
            Console.Write("Informe sua 2° Nota: ");
            n2 = float.Parse(Console.ReadLine());
            
            Console.Write("Informe sua 3° Nota: ");
            n3 = float.Parse(Console.ReadLine());
            
            Console.Write("Informe sua 4° Nota: ");
            n4 = float.Parse(Console.ReadLine());
            
            Console.Write("Informe o % de Frequencia: ");
            percFreg = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media < 5 && percFreg <= 40)
                Console.WriteLine("Aluno Reprovado /:");

            else if (media < 7 && percFreg <= 60)
                Console.WriteLine("Aluno de Recuperação -_-");

            else if (media <= 10 && percFreg > 60)
                Console.WriteLine("Aluno Aprovado (:");

            else
                Console.WriteLine("Será analisado pela secretaria acadêmica");




        }
    }
}
