// Bibliotecas
using System;

// Programa
namespace EX_09
{
    // Classe
    public class Classe
    {
        // Método Principal
        public static void Main(string [] args)
        {
            // Variáveis
            int num;
            int i = 1;
            int fat = 1;
            
            // Entrada de Dados
            Console.Clear();
            Console.Write("\n - Digite o Número: ");
            num = int.Parse( Console.ReadLine() );// Conversão (Int) <-- (String)
        
            // Estrutura de Repetição
            while( i <= num )
            {
                fat *= i;
                i++;
            }

            // Apresentação de Dados
            Console.Clear();
            Console.Write("\n -------------------- ");
            Console.Write("\n - Fatorial: " + fat );
            Console.Write("\n -------------------- \n\n");
        }
    }
}
