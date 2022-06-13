using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
    
    int numeroAnterior = 0;
    int numeroAtual = 1;
    int fibonacci;
   
   for (int i = 0; i <5;  i++ )
    {  
        fibonacci = numeroAnterior + numeroAtual; 
        numeroAnterior = numeroAtual; 
        numeroAtual = fibonacci;   
        Console.WriteLine  (fibonacci);
    }
          }
    }
}
