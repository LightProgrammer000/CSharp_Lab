// Bibliotecas
using System;

namespace EX_12
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            char cod = 'A';

            while (cod != 'n' && cod != 'N')
            {
                Menu();

                cod = Menu_Interativo(cod);
            }
        }

        /////////////////////// FUNÇÕES ///////////////////////

        private static void Menu()
        {
            //
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            // Variável
            int a;

            Console.Write("\n ================================= ");
            Console.Write("\n                MENU               ");
            Console.Write("\n ================================= ");
            Console.Write("\n\n - [1] Verificar Número Primo");
            Console.Write("\n - [2] Lista de Divisível");
            Console.Write("\n - [3] Tabuada");
            Console.Write("\n\n - Resp.: ");
            a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Write("\n - Resultado: " + Primo());
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("\n ==--== Listagem ==--== \n " + Divisiveis());
                    Console.ReadLine();
                    break;

                case 3:
                    Tabuada();
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
        }

        private static void Tabuada()
        {
            //
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //
            int a, i = 1;

            Console.Write("\n -------------------------- ");
            Console.Write("\n           Tabuada          ");
            Console.Write("\n -------------------------- ");

            Console.Write("\n\n - Digite um Número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("\n ************************************************************ \n");
            while (i <= 10)
            {
                Console.WriteLine("\n # [" + (a) + "] x [" + (i) + "] = [" + (a * i) + "]");

                // Incrementador
                i++;
            }
            Console.Write("\n ************************************************************ \n");
            Console.WriteLine("");
        }

        private static string Divisiveis()
        {
            //
            int a;
            int i = 1;
            string list_div = "- ";

            //
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            //
            Console.Write("\n ----------------------------- ");
            Console.Write("\n           Divisiveis          ");
            Console.Write("\n ----------------------------- ");

            Console.Write("\n\n - Digite um Número: ");
            a = int.Parse(Console.ReadLine());

            while ( i <= a )
            {
                if (a % i == 0)
                {
                    list_div += i + " \n - ";
                }
                i++;
            }

            return (list_div);
        }

        private static string Primo()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Variáveis
            int a;
            int i = 1, cont_zero = 0;
            string res = "Número";

            Console.Write("\n ------------------------- ");
            Console.Write("\n           Primo           ");
            Console.Write("\n ------------------------- ");

            // Entrada de Dados
            Console.Write("\n\n - Digite um Número: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (i <= a)
            {
                if (a % i == 0)
                {
                    cont_zero++;
                }

                if (cont_zero > 2)
                {
                    break;
                }

                i++;
            }

            if (cont_zero == 2)
            {
                return(res + " Primo\n\n");
            }

            else if (cont_zero > 2 )
            {
                return(res + " Não Primo\n\n");
            }

            else
            {
                return ("1 é Divisor Universal");
            }
        }

        private static char Menu_Interativo(char cod)
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            // Variáveis
            int resp;

            Console.Write("\n - Deseja Voltar: ");
            Console.Write("\n [1] - Sim");
            Console.Write("\n [2] - Não");
            Console.Write("\n\n - Resp.: ");

            resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    return ('s');

                default:
                    return ('n');
            }
        }
    }
}
