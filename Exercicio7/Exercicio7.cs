using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Exercicio7
    {
        static double MDC (double numerador, double denominador)
        {
            double menorNumero = Math.Min(numerador, denominador);
            for (double i = menorNumero; menorNumero > 0; i--)
            {
                if (numerador % i == 0 && denominador % i ==0)
                {
                    return i;
                } 
            }

            return 0;
        }

        static void Simplifica (ref double numerador, ref double denominador, double menorNumero)
        {
            numerador = numerador / menorNumero;
            denominador = denominador / menorNumero;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numerador da fração: ");
            double numerador = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o denominador da fração: ");
            double denominador = double.Parse(Console.ReadLine());

            Console.WriteLine($"A fração atual é: {numerador}/{denominador}\n");

            double menorNumero = MDC(numerador, denominador);

            Simplifica(ref numerador, ref denominador, menorNumero);

            Console.WriteLine($"A fração simplificada será: {numerador}/{denominador}");

            Console.ReadLine();

        }
    }
}
