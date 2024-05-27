using System;

namespace Exercicio2
{
    internal class Exercicio2
    {
            static double CoversorDeTemperatura(double tempCelsius)
            {
                double tempFah = tempCelsius * (9.0 / 5.0) + 32.0;
                return tempFah;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em ºC: ");
            double tempCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine($"A temperatura em ºF é: {CoversorDeTemperatura(tempCelsius)}");

            Console.ReadLine();


        }
    }
}
