using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Exercicio6
    {
        static double CaculaSerieDeNumeros(int number)
        {
            double soma = 0;

            for (int i = 1; i <= number; i++)
            {
                soma += (Math.Pow(i,2) + 1) / (double)(i + 3);
            }

            return soma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma da série será: {Math.Round(CaculaSerieDeNumeros(number),2)}");

            Console.ReadLine();
        }
    }
}
