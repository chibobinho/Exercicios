using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, você está no RH, qual o seu nome?");
            string Nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo, " + Nome);

            Console.WriteLine("Qual o seu salário atualmente?");
            float Salario = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu salário atualmente é de R$" + Salario + ", aqui na empresa estamos aumentando quem recebe menos de R$500");

            if (Salario < 500)
            {
                Console.WriteLine("Parabéns, você receberá um aumento de 30%!");
                double Aumento = Salario * 1.5;
                Console.WriteLine("Seu salário agora é de R$" + Aumento + "!");
            }
            
            else
            {
                Console.WriteLine("Seu salário ja é superior a R$500, não podemos fazer nada!");
            }
        }
    }
}
