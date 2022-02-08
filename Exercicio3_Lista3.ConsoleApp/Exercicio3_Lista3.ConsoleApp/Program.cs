using System;

namespace Exercicio3_Lista3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            int soma = 0;

            for (int i = 0; i < 500; i++)
            {
                zero = zero + 1;
                if (zero % 2 != 0 && zero % 3 == 0)
                {
                    soma = soma + zero;
                }            
            }
            Console.WriteLine(soma);
        }
    }
}
