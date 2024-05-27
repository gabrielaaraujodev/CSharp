using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Exercicio5
    {
            static bool EhTriangulo(double primeiroLado, double segundoLado, double terceiroLado)
            {
                if (primeiroLado + segundoLado > terceiroLado && primeiroLado + terceiroLado > segundoLado && segundoLado + terceiroLado > primeiroLado)
                {
                    return true;
                }

                return false;
            }

            static void TipoDeTriangulo(double primeiroLado, double segundoLado, double terceiroLado)
            {
                if (primeiroLado == segundoLado && primeiroLado == terceiroLado)
                {
                    Console.WriteLine("Triangulo EQUILÁTERO");
                } else if (primeiroLado != segundoLado && primeiroLado!= terceiroLado)
                {
                Console.WriteLine("Triangulo ESCALENO");
                } else
                {
                    Console.WriteLine("Triangulo ISÓSCELES");
                }
            }
        static void Main(string[] args)
        {

            double primeiroLado, segundoLado, terceiroLado;
            do
            {
                Console.WriteLine("Informe os lados do triangulo: ");
                primeiroLado = double.Parse(Console.ReadLine());
                segundoLado = double.Parse(Console.ReadLine());
                terceiroLado = double.Parse(Console.ReadLine());

                if (primeiroLado < 0 || segundoLado < 0 || terceiroLado < 0)
                {
                    Console.WriteLine("Nenhum lado pode ter valor negativo, informe os lados novamente !");
                }
                
            } while (primeiroLado < 0  || segundoLado < 0 || terceiroLado < 0);

            Console.WriteLine($"Dado os valores dos lados, pode-se formar um triangulo ? {EhTriangulo(primeiroLado, segundoLado, terceiroLado)}");

            if(EhTriangulo(primeiroLado, segundoLado, terceiroLado))
            {
                TipoDeTriangulo(primeiroLado, segundoLado, terceiroLado);
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo !");
            }

            Console.ReadLine();

        }
    }
}
