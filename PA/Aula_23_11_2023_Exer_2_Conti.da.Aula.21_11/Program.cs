using System;

namespace Aula_23_11_2023_Exer_2_Conti.da.Aula._21_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCandidato1 = 0, totalCandidato2 = 0, totalCandidato3 = 0, totalCandidato4 = 0, totalNulo5 = 0, totalBranco6 = 0;
            int voto = -1, percVotoNulos = 0, percVotoBrancos = 0;            
            
            while (voto != 0)
            {
                Console.Clear();
                Console.WriteLine("*Opções");
                Console.WriteLine("Candidato1 = 1");
                Console.WriteLine("Candidato2 = 2");
                Console.WriteLine("Candidato3 = 3");
                Console.WriteLine("Candidato4 = 4");
                Console.WriteLine("*Nulo = 5");
                Console.WriteLine("*Branco = 6");
                Console.Write("Digite o número do seu voto: ");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        totalCandidato1 += 1;
                        break;
                    case 2:
                        totalCandidato2 += 1;
                        break;
                    case 3:
                        totalCandidato3 += 1;
                        break;
                    case 4:
                        totalCandidato4 += 1;
                        break;
                    case 5:
                        totalNulo5 += 1;
                        break;
                    case 6:
                        totalBranco6 += 1;
                        break;

                    default:
                        if (voto != 0)
                        {
                        Console.WriteLine("Voto não computado");
                        Console.ReadLine();
                        }
                        break;
                }




            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("** Apuração **");
            Console.WriteLine("----------------");
            Console.WriteLine($"Total de votos do Candidato1: {totalCandidato1}");
            Console.WriteLine($"Total de votos do Candidato2: {totalCandidato2}");
            Console.WriteLine($"Total de votos do Candidato3: {totalCandidato3}");
            Console.WriteLine($"Total de votos do Candidato4: {totalCandidato4}");
            Console.WriteLine($"Total de votos Nulos: {totalNulo5}");
            Console.WriteLine($"Total de votos Brancos {totalBranco6}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Até a proxima (;");

            Console.WriteLine($"% de Nulos: {totalNulo5 / totalCandidato1 + totalCandidato2 + totalCandidato3 + totalCandidato4}%");
            Console.WriteLine($"% de Brancos: {totalBranco6 / totalCandidato1 + totalCandidato2 + totalCandidato3 + totalCandidato4}%");


        }
    }
}
