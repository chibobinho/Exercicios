using System;

namespace Nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.Write(nomePessoa + ", qual foi o ano que você nasceu? ");
            float anoNascimento = int.Parse(Console.ReadLine());
            float idade = 2022 - anoNascimento;
            float semanas = idade * 52;

            Console.WriteLine("Então sua idade é: " + Math.Round(idade));
            Console.WriteLine("E em semanas: " + Math.Round(semanas, 1));

        }
    }
}
