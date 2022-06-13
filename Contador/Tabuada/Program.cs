using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADAS DO 1 ATÉ O 10 VOCÊ SÓ ENCONTRA AQUI, CONFIA!");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do " + i);
                for (var a = 1; a <= 10; a++)
                {
                Console.WriteLine(i + " * " + a + " = " + (i*a));
                }
                // i = numero da Tabuada
                // a = numero da multiplicação
            }
        }
    }
}
