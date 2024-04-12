using Proj1;
using System;
using System.Globalization;
using System.Numerics;

namespace Dados
{

    class Prgram
    {


        static void Main(string[] args)
        {


            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("Informe a quantidade de quartos que deseja alugar");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}");

                Console.WriteLine($"Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Número do Quarto");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }


            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }

                {



                }

            }




        }

    }
}

