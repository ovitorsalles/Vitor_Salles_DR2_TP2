using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao11
    {
        public Questao11()
        {
            Console.Write("Digite um número para calcular a tabuada: ");
            int numero;

            // Verifica se a entrada é um número válido
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Por favor, digite um número válido: ");
            }

            // Exibe a tabuada de 1 a 10
            Console.WriteLine($"\nTabuada do {numero}:");

            // Laço de repetição para calcular a tabuada
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
