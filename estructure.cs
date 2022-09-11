using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_27
{
    class Program
    {
        struct Carro
        {
            // Atributos
            private int rodas;
            private int portas;
            private float altura;
            private float largura;

            // Construtor
            public Carro(int rodas, int portas, float altura, float largura)
            {
                this.rodas = rodas;
                this.portas = portas;
                this.altura = altura;
                this.largura = largura;
            }

            public int Rodas()
            {
                return (rodas);
            }
        }

        struct Casa
        {
            private float altura;
            private float largura;
            private float comprimento;

            public Casa(float altura, float largura, float comprimento)
            {
                this.altura = altura;
                this.largura = largura;
                this.comprimento = comprimento;
            }

            public float Calc_Area(float comprimento, float largura)
            {
                return (comprimento * largura);
            }
        }

        struct Pessoa
        {
            public int cpf;
            public int rg;
            public string nome;
            public string sobrenome;
            
            public string Nome_Completo( string nome, string sobrenome)
            {
                string nome_completo = nome + sobrenome;

                return (nome_completo);
            }
        }

        struct Escola
        {
            public int salas;
            public int alunos;
            public int materias;
            public int professores;
        }

        static void Main(string[] args)
        {
            // Carro: Instanciação
            Carro car = new Carro(4, 4, 1.78f, 1.98f);

            // Casa: Instanciação
            Casa cas = new Casa(6.7f, 4.3f, 10.4f);

            // Pessoa: Variável Estrutural
            Pessoa pessoa;
            pessoa.nome = "Light";
            pessoa.sobrenome = "Programmer000";
            pessoa.rg = 12345;
            pessoa.cpf = 1234567890;

            // Escola: Variável Estrutural
            Escola escola;
            escola.salas = 40;
            escola.alunos = 60;
            escola.materias = 16;
            escola.professores = 16;

            // Mensagem
            Console.Write("\n - {0} ", car.Rodas() );
            Console.Write("\n - {0} ", cas.Calc_Area(10, 15));
            Console.Write("\n - {0} ", pessoa.Nome_Completo(pessoa.nome, pessoa.sobrenome));
            Console.WriteLine("\n - Salas: {0}\n - Alunos: {1}\n - Matérias: {2}\n - Professores: {3}", escola.salas, escola.materias, escola.professores, escola.professores + "\n");
        }
    }
}
