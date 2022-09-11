// Bibliotecas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programa
namespace EX_19
{
    // Classe
    class Programa
    {
        // Método Principal
        static void Main(string[] args)
        {
            //Tecnica_1();
            //Tecnica_2();
            //Tecnica_3();
            //Tecnica_4();
        }

        private static void Tecnica_1()
        {
            int i;
            int[] list_num = new int[] { 10, 34, 23, 21, 56, 78, 47, 18, 89 }; // Lista
            int[] Clone_list_num = new int[list_num.Length]; // Clone

            for (i = 0; i < Clone_list_num.Length; i++)
            {
                Clone_list_num[i] = list_num[i];
            }

            for (i = 0; i < Clone_list_num.Length; i++)
            {
                Console.WriteLine("\n - Posição [" + i + "]: " + Clone_list_num[i]);
            }

            Console.WriteLine("");
        }

        private static void Tecnica_2()
        {
            int[] lista = new int[] {1,2,3,4,5,6,7,7,84,3,2,2,57,6,5,43,23,456,7,6};
            int[] clone_lista = new int[lista.Length];

            // Copiando com o método: 'CopyTo'
            // CopyTo(Array, A partir de índice... )
            lista.CopyTo(clone_lista, 0);

            foreach(int elemento in clone_lista)
            {
                Console.WriteLine("\n Elemento: " + elemento);
            }
        }

        private static void Tecnica_3()
        {
            int[] lista = new int[] { 1, 2, 3, 98, 43, 2, 11, 223, 432, 12, 67, 54, 32, 67, 98, 76, 543, 32 };
            int[] clone = new int[lista.Length];

            // Copiando Array - Origem -- Destino -- Tamanho
            Array.Copy(lista,clone, clone.Length);

            foreach ( int elemento in clone )
            {
                Console.WriteLine("\n - Elemento: " + elemento);
            }
        }

        private static void Tecnica_4()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 9, 3, 1, 5 };
            int[] copia = (int []) num.Clone();

            foreach (int elemento in copia)
            {
                Console.WriteLine("\n - Elemento: " + elemento);
            }
        }
    }
}
