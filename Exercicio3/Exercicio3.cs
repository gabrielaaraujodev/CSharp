using System;

namespace Exercicio3
{
    internal class Exercicio3
    {
        static double CalculaMedias(double primeiraNota, double segundaNota, double terceiraNota, char letra)
        {
            switch (letra) 
            {
                case 'A':
                    return (primeiraNota + segundaNota +terceiraNota) / 3;

                case 'P':
                    return (primeiraNota*5 + segundaNota*3 + terceiraNota*2) / 10;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:\nA) Média Aritimética\nP) Média Ponderada");
            char letra = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe suas 3 notas: ");
            double primeiraNota= double.Parse(Console.ReadLine());
            double segundaNota= double.Parse(Console.ReadLine());
            double terceiraNota= double.Parse(Console.ReadLine());

            Console.WriteLine(CalculaMedias(primeiraNota, segundaNota, terceiraNota, letra));

            Console.ReadLine();
        }
    }
}
