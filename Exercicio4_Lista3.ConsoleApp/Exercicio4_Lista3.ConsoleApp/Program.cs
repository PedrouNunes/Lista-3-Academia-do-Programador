using System;

namespace Exercicio4_Lista3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A tabuada de " + A + " é: ");

            double tabuada;
            for (int i = 0; i < 11; i++)
            {  
                tabuada = A * i;
                Console.WriteLine(i + " X " + A + " = " + tabuada);
            }
        }
    }
}
