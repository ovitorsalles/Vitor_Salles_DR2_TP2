using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao10
    {
        public Questao10() {
            // Solicita um número ao usuário
            Console.Write("Digite um número para iniciar a contagem regressiva: ");
            int numero;

            // Verifica se a entrada é um número válido
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Por favor, digite um número válido (maior ou igual a 0): ");
            }

            // Laço de repetição para exibir a contagem regressiva
            for (int i = numero; i >= 0; i--)
            {
                if (i != numero)
                {
                    Console.Write(", ");
                }
                Console.Write(i);
            }

            // Quebra de linha após a contagem
            Console.WriteLine();
        }
    }
}

