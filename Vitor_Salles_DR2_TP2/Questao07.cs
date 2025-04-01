using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao07
    {
        public Questao07()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número válido: ");
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }
    }
}
