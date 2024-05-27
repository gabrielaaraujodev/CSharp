using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_4___Exercicio01
{
    internal class Exercicio1
    {
        static void PositivoOuNegativo (double number)
        {
            if (number > 0)
            {
                Console.WriteLine("positivo");
            } else if (number == 0)
            {
                Console.WriteLine("0");
            } else
            {
                Console.WriteLine("Negativo");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            double number = double.Parse(Console.ReadLine());

            PositivoOuNegativo(number);
            Console.ReadLine();
        }
    }
}
