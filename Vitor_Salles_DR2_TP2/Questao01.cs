using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao01
    {
        static void Main()
        {
            Console.Write("Digite a sua data de nascimento (dd/mm/aaaa): ");
            string input = Console.ReadLine();

            DateTime nascimento;
            if (DateTime.TryParse(input, out nascimento))
            {
                DateTime hoje = DateTime.Now;

                int anos =  hoje.Year - nascimento.Year;
                int meses = hoje.Month - nascimento.Month;
                int dias = hoje.Day - nascimento.Day;
                Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.");
            } else
            {
                Console.WriteLine("Data inválida. Tente novamente.");
            }
        }
    }
}
