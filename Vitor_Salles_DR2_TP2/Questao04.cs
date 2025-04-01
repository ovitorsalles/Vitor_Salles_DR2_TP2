using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitor_Salles_DR2_TP2
{
    internal class Questao04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.WriteLine("Idade inválida. Digite uma idade válida: ");
            }

            Console.WriteLine("Digite o seu telefone (xx) xxxx-xxxx: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine("\n--- Dados Cadastrados ---");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"E-mail: {email}");
        }
    }
}
