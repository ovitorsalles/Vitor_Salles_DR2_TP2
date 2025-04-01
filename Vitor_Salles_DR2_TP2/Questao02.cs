using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao02
    {
        static void Main()
        {
            // Solicita a data de nascimento ao usuário
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
            string input = Console.ReadLine();

            // Converte a string para um objeto DateTime
            DateTime nascimento;
            if (DateTime.TryParse(input, out nascimento))
            {
                // Obtém a data atual
                DateTime hoje = DateTime.Now;

                // Cria uma nova data para o próximo aniversário
                DateTime aniversarioProximo = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

                // Se o aniversário já passou este ano, define para o próximo ano
                if (aniversarioProximo < hoje)
                {
                    aniversarioProximo = aniversarioProximo.AddYears(1);
                }

                // Calcula a diferença entre o próximo aniversário e a data atual
                TimeSpan diasParaAniversario = aniversarioProximo - hoje;

                // Exibe a quantidade de dias faltando para o próximo aniversário
                Console.WriteLine($"Faltam {diasParaAniversario.Days} dias para o seu próximo aniversário.");
            }
            else
            {
                // Caso o formato da data seja inválido
                Console.WriteLine("Data inválida. Tente novamente.");
            }
        }
    }

}
