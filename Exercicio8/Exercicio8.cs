using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Exercicio8
    {
        static double MediaVetor(double[] vetor)
        {
            double soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];                
            }
            soma = soma / vetor.Length;

            return soma;
        }
        static void Main(string[] args)
        {
            double[] vet = new double [5];
            Random random = new Random();

            for (int i = 0; i < vet.Length; i++) { 
                vet[i] = random.Next(1,21);
            }

            Console.WriteLine($"A média dos valores do vetor é: {Math.Round(MediaVetor(vet),2)}");

            Console.ReadLine();
        }
    }
}
