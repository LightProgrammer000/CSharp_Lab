// Biblioteca
using System;

// Programa
namespace EX_09
{
    // Classe
    public class Program
    {
        // Método Principal
        public static void Main(string[] args)
        {
            // Variáveis
            string nom;
            string end;
            string tel;
            string ano_atual;
            int idade, ano_nasc;

            // Apresentação
            Console.Clear();
            Console.Write("\n ---------- FORMULARIO ---------- \n\n");

            // Nome
            Console.Write(" - Digite Nome: ");
            nom = Console.ReadLine();// String

            // Endereço
            Console.Write(" - Digite Endereço: ");
            end = Console.ReadLine();// String
              
            // Telefone
            Console.Write(" - Digite Telefone: ");
            tel = Console.ReadLine();// String

            // Ano de Nascimento
            Console.Write(" - Digite Ano de Nascimento: ");
            ano_nasc = Convert.ToInt32(Console.ReadLine());// Conversão INT <-- String

            // Captura do Ano Atual
            ano_atual = DateTime.Now.ToString("yyyy");

            // Cálculo da Idade
            idade = Convert.ToInt32(ano_atual) - ano_nasc;

            // Relatório
            Console.Clear();
            Console.WriteLine("\n ---------- RELATÓRIO ----------");
            Console.WriteLine("\n - Nome: " + nom);
            Console.WriteLine("\n - Endereço: " + end);
            Console.WriteLine("\n - Telefone: " + tel);
            Console.WriteLine("\n - Ano de Nascimento: " + ano_nasc);
            Console.WriteLine("\n - Ano Atual: " + ano_atual);
            Console.WriteLine("\n - Idade: " + idade);
            Console.WriteLine(" ----------------------------- ");
        }
    }
}
