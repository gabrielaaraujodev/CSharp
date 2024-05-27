using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Exercicio11
    {
        static double SomaAbaixoDp(double[,] mat)
        {
            double soma = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    soma += mat[i, j];
                }
            }

            return soma;
        }
        static void Main(string[] args)
        {
            double[,] matriz = new double[3, 3];
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = random.Next(1,21);
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"A soma dos elementos abaixod da diagonal principal é: {SomaAbaixoDp(matriz)}");

            Console.ReadLine();
        }
    }
}
