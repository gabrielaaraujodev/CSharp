using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Exercicio10
    {
        static int ValoresMaioresQueDez(double[,] mat)
        {
            int cont = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i,j] > 10) 
                        cont++;
                }
            }

            return cont;
        }
        static void Main(string[] args)
        {
            double[,] matriz = new double[5,5];
            Random rand= new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = rand.Next(1,21);
                    Console.Write (matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"A quantidade de números maiores que 10 presentes na matriz é: {ValoresMaioresQueDez(matriz)}");

            Console.ReadLine();
        }
    }
}
