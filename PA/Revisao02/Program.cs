using System;

namespace Revisao02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write("Informe um número: ");
            valor = int.Parse(Console.ReadLine());

            if (valor == 5)
                Console.WriteLine("O valor informado é 5");

            else
                Console.WriteLine("O valor informado é diferente de 5");

           
            string email;

            Console.Write("Informe o e-mail: ");
            email = Console.ReadLine();

            if (email == "eduardo@etec.com.br")
                Console.WriteLine("Acesso liberado");

            else
                Console.WriteLine("Acesso bloqueado");




         }
    }
}
