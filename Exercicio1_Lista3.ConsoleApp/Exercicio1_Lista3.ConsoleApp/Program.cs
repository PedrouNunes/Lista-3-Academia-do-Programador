using System;

namespace Exercicio1_Lista3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] altura = new double[15];
            double maior = 0;
            double menor = 999999999;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite a altura da pessoa " + i + " em metros: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());

                if (altura[i] > maior)
                {
                    maior = altura[i];
                }
                if (altura[i] < menor)
                {
                    menor = altura[i];
                }

            }
            Console.WriteLine("A menor altura do grupo é: " + menor + "m, e a maior é: " + maior + "m.");
        }
    }
}
