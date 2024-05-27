using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Exercicio9
    {
        static void ImprimirVetor(double[] vet)
        {
            Random rand = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rand.Next(1,21);
            }

            foreach (int i in vet) 
            { 
                Console.Write(i + " ");
            } 
        }

        static void VetorInverso(double[] vet)
        {
            for (int i = vet.Length - 1; i >= 0; i--)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void MaiorMenor(double[] vet, out double maior, out double menor) 
        {
            maior = double.MinValue;
            menor = double.MaxValue;

            for (int i = 0; i < vet.Length; i++) 
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
                else if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }
        }
        static void Main(string[] args)
        {
            double[] vetor = new double[10];
            double maior, menor;

            ImprimirVetor(vetor);
            Console.WriteLine();
            VetorInverso(vetor);
            Console.WriteLine();
            MaiorMenor(vetor, out maior, out menor);
            Console.WriteLine($"O maior número do vetor é: {maior} e o menor é: {menor}"); 

            Console.ReadLine();
        }
    }
}
