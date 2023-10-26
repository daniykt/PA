using System;

namespace Aula_26_10_2023_exemplo02_banco_
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorFinanciado, valorParcela; //valorParcela
            int qtdParcela, contador = 1;

            Console.Write("Informe o valor Financiado: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a Qtde de Parcelas: ");
            qtdParcela = int.Parse(Console.ReadLine());

            valorParcela = valorFinanciado / qtdParcela;

            DateTime data = DateTime.Now.Date;

            while (contador <= qtdParcela)
            {
                //Console.WriteLine($"O valor da Parcela {contador} é de {valorParcela} ");
                Console.WriteLine($"{contador} parcela: ({data}): {valorParcela.ToString("0.00")}");
                //Console.WriteLine($"{contador} parcela: {valorParcela:0.00}");
                //Console.WriteLine($"{contador} parcela: {valorFinanciado / qtdParcela:0.00}");
                contador++;
                data = data.AddMonths(1);
            }


        }
    }
}
