// Bibliotecas
using System;

namespace EX_11
{
    // Classe
    public class Programa
    {
        // Método Principal
        public static void Main(string[] args)
        {
            while (true)
            {
                // Sistema
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                // Variáveis
                double media;

                // Apresentação
                Console.Write("\n ------------------------ ");
                Console.Write("\n           MEDIA          ");
                Console.Write("\n ------------------------ \n");

                // Chamada de Procedimento
                media = Calculos();
                Conclusao(media);
            }
        }

        private static double Calculos()
        {
            int i;
            double[] nota = new double[5];// Array
            double soma_valor = 0;

            for (i = 0; i < 4; i++)
            {
                Console.Write("\n - Digite Nota [" + (i+1) + "]: ");
                nota[i] = Convert.ToDouble(Console.ReadLine());

                soma_valor += nota[i];
            }

            return (Media(soma_valor, i));
        }

        private static double Media(double valor, int qtd)
        {
            return (valor / qtd);
        }

        private static void Conclusao(double media)
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Apresentação + Entrada de Dados
            Console.Write("\n --------------------------- ");
            Console.Write("\n           SITUAÇÃO          ");
            Console.Write("\n --------------------------- ");

            // Estrutura de Decisao
            if (media >= 7 && media <= 10)
            {
                Console.Write("\n\n - Media: " + media);
                Console.Write("\n - Situação: Aprovado\n");
            }

            else if (media >= 5 && media < 7)
            {
                Console.Write("\n\n - Media: " + media);
                Console.Write("\n - Situação: Recuperação\n");
            }

            else if (media >= 0 && media < 5)
            {
                Console.Write("\n\n - Media: " + media);
                Console.Write("\n - Situação: Reprovado\n");
            }

            // Pausa
            Console.ReadLine();
        }
    }
}
