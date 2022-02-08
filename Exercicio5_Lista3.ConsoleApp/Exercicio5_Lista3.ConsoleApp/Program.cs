using System;

namespace Exercicio5_Lista3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());
          
            int fatorial = 1;         
            for (int i = 0; i < A; i++)
            {
                fatorial = fatorial * (A - i);
            }
            Console.WriteLine("O fatorial de " + A  + " é: " + fatorial);
        }
    }
}
