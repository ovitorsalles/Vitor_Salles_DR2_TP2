using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao08
    {
        public Questao08() {
            Console.WriteLine("Digite uma nota de 0 a 10");
            int nota;
            while (!int.TryParse(Console.ReadLine(), out nota))
            {
                Console.WriteLine("Digite uma nota válido: ");
            };

           if (nota < 5) {
                Console.WriteLine("Insuficiente");
            } else if (nota < 7) {
                Console.WriteLine("Regular");
            } else if (nota < 9) {
                Console.WriteLine("Bom");
            } else if (nota <= 10) {
                Console.WriteLine("Excelente");
            }
        }
    }
}
