using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao05
    {
        public Questao05() {
            Console.WriteLine("Digite a temperatura em ºC: ");
            double celsius;
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.Write("Por favor, digite um valor válido em Celsius: ");
            }

            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("Celsius: " + celsius + "ºC");
            Console.WriteLine("Fahrenheit: " + fahrenheit + "ºC");
            Console.WriteLine("Kelvin: " + kelvin + "ºC");

        }
    }
}
