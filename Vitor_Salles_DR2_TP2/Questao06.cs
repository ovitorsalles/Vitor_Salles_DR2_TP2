using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao06
    {
        public Questao06()
        {
            Console.WriteLine("Digite a sua altura: ");
            double altura;
            while (!double.TryParse(Console.WriteLine(), out altura)) {
                Console.WriteLine("Por favor, digite uma altura válida");
            }

            Console.WriteLine("Digite o seu peso: ");
            double peso;
            while (!double.TryParse(Console.WriteLine(), out peso)) {
                Console.WriteLine("Por favor, digite um peso válido");
            }

            double imc = peso / (altura * altura);

            Console.WriteLine("O seu imc é: " + imc);
        }
    }
}
