using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao03
    {
        static void Main()
        {
            // Solicita a primeira data ao usuário
            Console.Write("Digite a primeira data (dd/mm/aaaa): ");
            string input1 = Console.ReadLine();

            // Solicita a segunda data ao usuário
            Console.Write("Digite a segunda data (dd/mm/aaaa): ");
            string input2 = Console.ReadLine();

            // Converte as strings para objetos DateTime
            DateTime data1;
            DateTime data2;

            if (DateTime.TryParse(input1, out data1) && DateTime.TryParse(input2, out data2))
            {
                // Calcula a diferença entre as duas datas
                TimeSpan diferenca = data2 - data1;

                // Calcula a diferença em anos, meses e dias
                int anos = data2.Year - data1.Year;
                int meses = data2.Month - data1.Month;
                int dias = diferenca.Days;

                // Ajusta para quando a diferença de meses é negativa
                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                // Exibe o resultado
                Console.WriteLine($"A diferença entre as duas datas é de {anos} anos, {meses} meses e {dias} dias.");
            }
            else
            {
                // Caso as datas sejam inválidas
                Console.WriteLine("Uma ou ambas as datas são inválidas. Tente novamente.");
            }
        }
    }
}
