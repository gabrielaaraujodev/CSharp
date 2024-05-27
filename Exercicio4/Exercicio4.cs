using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Exercicio4
    {
        static double Calculo(double numberOne, double numberTwo, char simbol)
        {
            switch (simbol)
            {
                case '+':
                    return numberOne + numberTwo;
                case '-':
                    return numberOne - numberTwo;
                case '*':
                    return numberOne * numberTwo;
                case '/':
                    return numberOne / numberTwo;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o operador matemático: \nPara soma: +\nPara Subtração: -\nPara Multiplicação: *\nPara Divisão: /");
            char simbol = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe os dois numeros para realizar a operação: ");
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculo(numberOne, numberTwo, simbol));
            Console.ReadLine();
        }
    }
}
