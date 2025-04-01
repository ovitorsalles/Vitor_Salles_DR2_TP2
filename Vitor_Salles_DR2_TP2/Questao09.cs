using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao09
    {
        public Questao09() {
            // Solicita o salário bruto ao usuário
            Console.Write("Digite o seu salário bruto: R$ ");
            double salarioBruto;

            // Verifica se a entrada é válida
            while (!double.TryParse(Console.ReadLine(), out salarioBruto) || salarioBruto < 0)
            {
                Console.Write("Por favor, digite um valor válido para o salário bruto: R$ ");
            }

            // Variáveis para calcular os descontos e salário líquido
            double imposto = 0;
            double salarioLiquido = salarioBruto;

            // Define as faixas de imposto
            if (salarioBruto <= 2000)
            {
                imposto = 0;  // Sem imposto
            }
            else if (salarioBruto <= 5000)
            {
                imposto = salarioBruto * 0.10;  // 10% de imposto
            }
            else
            {
                imposto = salarioBruto * 0.20;  // 20% de imposto
            }

            // Calcula o salário líquido
            salarioLiquido = salarioBruto - imposto;

            // Exibe os resultados
            Console.WriteLine("\n--- Detalhes do Salário ---");
            Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto de Imposto: R$ {imposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }
    }
}
