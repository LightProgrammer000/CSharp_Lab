// Bibliotecas
using System;

// Programa
namespace EX_17
{
    // Classe
    public class Programa
    {
        // Método Principal
        public static void Main(string[] args)
        {
            // Variável
            string cod = "A";

            while (cod != "n" && cod != "N")
            {
                // Chamada de Método
                Menu();

                // Retorno de Menu
                cod = Menu_Loop(cod);
            }
        }

        //////////////////////////////// FUNÇÕES ////////////////////////////////
        private static void Menu()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            // Variáveis
            int resp;

            // Apresentação + Entrada de Dados
            Console.Write("\n ============================= ");
            Console.Write("\n              MENU             ");
            Console.Write("\n ============================= ");
            Console.Write("\n\n - [1] Fatorial");
            Console.Write("\n - [2] Divisiveis");
            Console.Write("\n - [3] Primo");
            Console.Write("\n - [4] Tabuada");
            Console.Write("\n - [5] Potência");
            Console.Write("\n - [6] Raiz");
            Console.Write("\n - [7] Equação do 2º Grau [Raizes]");
            Console.Write("\n - [8] Soma de uma Progressão Aritmética");
            Console.Write("\n - [9] Soma de uma Progressão Geométrica");
            Console.Write("\n\n - Resp.: ");
            resp = int.Parse(Console.ReadLine());

            // Estrutura de Escolha [Funções]
            switch (resp)
            {
                case 1:
                    Fatorial();
                    break;

                case 2:
                    Divisivel();
                    break;

                case 3:
                    Primo();
                    break;

                case 4:
                    Tabuada();
                    break;

                case 5:
                    Potencia();
                    break;

                case 6:
                    Raiz();
                    break;

                case 7:
                    Eq_Seg_Gr();
                    break;

                case 8:
                    Soma_PA();
                    break;

                case 9:
                    Soma_PG();
                    break;

                default:
                    break;
            }
        }

        private static string Menu_Loop(string cod)
        {
            // Sistema
            Console.ForegroundColor = ConsoleColor.Red;

            // Variáveis
            string a;

            // Entrada de Dados
            Console.Write("\n\n - Retornar ao Menu Principal...");
            Console.Write("\n - [s] Sim ");
            Console.Write("\n - [n] Não ");
            Console.Write("\n\n - Resp.: ");
            a = Console.ReadLine();

            // Proteção
            while (!a.Equals("s") && !a.Equals("n"))
            {
                Console.Clear();
                Console.Write("\n\n - Retornar ao Menu Principal...");
                Console.Write("\n - [s] Sim ");
                Console.Write("\n - [n] Não ");
                Console.Write("\n\n - Resp.: ");
                a = Console.ReadLine();
            }

            // Estrutura de Decisão
            if (a.Equals("s"))
            {
                return "s";
            }

            else
            {
                return "n";
            }
        }

        // Fatorial
        private static void Fatorial()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Variáveis
            int fat = 1;
            int num, aux;

            // Apresentação + Entrada de Dados
            Console.Write("\n ---------------------------- ");
            Console.Write("\n           FATORIAL           ");
            Console.Write("\n ---------------------------- ");

            Console.Write("\n\n - Digite um Número [Limite 12]: ");
            num = int.Parse(Console.ReadLine());
            aux = num;

            // Proteção
            while (num < 0 || num > 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n *** Digite um Número entre 1 e 12 ***");
                Console.Write("\n\n - Digite um Número [Limite 12]: ");
                num = int.Parse(Console.ReadLine());
                aux = num;
            }

            // Cálculo
            while (num > 1)
            {
                fat *= num;

                num--;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n - Fatorial [" + aux + "]: " + fat);
        }

        // Divisível
        private static void Divisivel()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Variáveis
            int num;
            int i = 1;
            string lista = "";

            // Apresentação + Entrada de Dados
            Console.Write("\n ----------------------------- ");
            Console.Write("\n           DIVISÍVEL           ");
            Console.Write("\n ----------------------------- ");

            Console.Write("\n\n - Digite um Número: ");
            num = int.Parse(Console.ReadLine());

            // Proteção
            if (num == 0)
            {
                Console.Write("\n - Número [0]: Não tem Divisores");
            }

            else if (num < 0)
            {
                Console.Write("\n - Número Negativos são Inválidos");
            }

            else
            {
                // Cálculo
                while (i <= num)
                {
                    if (num % i == 0)
                    {
                        lista += "\n - " + i;
                    }

                    // Incrementador
                    i++;
                }

                // Conclusão
                Console.Write("\n - Lista: " + lista);
            }
        }

        // Primo
        private static void Primo()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Variáveis
            int a;
            int i = 1;
            int cont_zero = 0;
            string res = "Número";

            // Apresentação + Entrada de Dados
            Console.Write("\n ------------------------- ");
            Console.Write("\n           PRIMO           ");
            Console.Write("\n ------------------------- ");

            Console.Write("\n\n - Digite um Número: ");
            a = int.Parse(Console.ReadLine());

            while (i <= a)
            {
                // Divisão Exata
                if (a % i == 0)
                {
                    cont_zero++;
                }

                // Restagem de "0" > 2
                if (cont_zero > 2)
                {
                    break;
                }

                i++;
            }

            // Análise Mediante a Contagem de "Zeros"
            if (cont_zero == 2)
            {
                Console.Write("\n - Situação: Primo");
            }

            else if (cont_zero > 2)
            {
                Console.Write("\n - Situação: Não Primo");
            }
        }

        private static void Tabuada()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            // Variáveis
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
            Console.Write("\n ************************************************************ ");
        }

        private static void Potencia()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            // Variáveis
            double num, exp;

            // Apresentação + Entrada de Dados
            Console.Write("\n ---------------------------- ");
            Console.Write("\n           Potencia           ");
            Console.Write("\n ---------------------------- ");

            Console.Write("\n\n - Digite um Número [Base]: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("\n - Digite o Expoente: ");
            exp = double.Parse(Console.ReadLine());

            // Saída de Dados
            Console.Write("\n - Resultado: " + Math.Pow(num, exp));
        }

        private static void Raiz()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            // Variáveis
            double num, ind;

            // Apresentação + Entrada de Dados
            Console.Write("\n ------------------------ ");
            Console.Write("\n           Raiz           ");
            Console.Write("\n ------------------------ ");

            Console.Write("\n\n - Digite um Número [Base]: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("\n - Digite o Índice: ");
            ind = double.Parse(Console.ReadLine());

            // Saída de Dados
            Console.Write("\n - Resultado: " + Math.Pow(num, 1 / ind));
        }

        private static void Eq_Seg_Gr()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Variáveis
            double a, b, c;
            double raiz1, raiz2;

            // Apresentação + Entrada de Dados
            Console.Write("\n ------------------------------------------- ");
            Console.Write("\n           Equação do Segundo Grau           ");
            Console.Write("\n               Ax² +- Bx +- C                ");
            Console.Write("\n ------------------------------------------- ");

            Console.Write("\n\n - Digite A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("\n - Digite B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("\n - Digite C: ");
            c = double.Parse(Console.ReadLine());

            // Cálculos das Raízes :  [ - b +- Raiz_Quadrada(Delta = (b² - 4ac) ] ) /2a

            // (-b + Delta1) / 2a -> Raiz 1
            raiz1 = (-b + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / 2 * a;

            // (-b + Delta2) / 2a -> Raiz 2
            raiz2 = (-b - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / 2 * a;

            // Conclusão
            Console.Write("\n - Raiz 1: " + raiz1);
            Console.Write("\n - Raiz 2: " + raiz2);
        }

        private static void Soma_PA()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Variáveis
            double a1, an, n, Sn;

            // Apresentação + Entrada de Dados
            Console.Write("\n ------------------------------------------------- ");
            Console.Write("\n           Soma de Progressão Matemática           ");
            Console.Write("\n ------------------------------------------------- ");

            Console.Write("\n\n - Digite o 1º Elemento [A1]: ");
            a1 = double.Parse(Console.ReadLine());

            Console.Write("\n - Digite o Último Elemento [An]: ");
            an = double.Parse(Console.ReadLine());

            Console.Write("\n - Digite a Quantidade de Termos [n]: ");
            n = double.Parse(Console.ReadLine());

            // Cálculo: Sn= [ (a1 + an) * n ] / 2
            Sn = (a1 + an) * n / 2;

            Console.Write("\n - Resultado [Soma] : " + Sn);
        }

        private static void Soma_PG()
        {
            // Sistema
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Variáveis
            double a1, q, n, Sn;

            // Apresentação + Entrada de Dados
            Console.Write("\n ------------------------------------------------- ");
            Console.Write("\n           Soma de Progressão Geométrica           ");
            Console.Write("\n ------------------------------------------------- ");

            Console.Write("\n\n - Digite o 1º Elemento [A1]: ");
            a1 = double.Parse(Console.ReadLine());

            Console.Write("\n - Digite a Razão [q]: ");
            q = double.Parse(Console.ReadLine());

            Console.Write("\n - Digite a Quantidade de Termos [n]: ");
            n = double.Parse(Console.ReadLine());

            // Cálculo: Sn = a1 * (q ^ n - 1 ) / q - 1
            Sn = ( a1 * (Math.Pow(q, n) - 1)) / (q - 1);

            // Apresentação do Dados
            Console.Write("\n - Resultado [Soma] : " + Sn );
        }
    }
}
