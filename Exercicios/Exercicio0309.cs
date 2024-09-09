using CursoCSharp.Guia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class Exercicio1
    {
        
    }

    /*public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }*/

    /*public class Calculadora1
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtracao(int a, int b)
        {
            return a - b;
        }
    }*/

    /*public class CarroNovo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }


        public void ExibirInfo()
        {
            Console.WriteLine($"{Modelo} - {Ano} - {Preco:F2}");
        }

        *//*
         * CarroNovo meuCarro = new CarroNovo();
            meuCarro.Modelo = "Fusca";
            meuCarro.Ano = 1976;
            meuCarro.Preco = 15000.00;

            meuCarro.ExibirInfo();
         *//*
    }*/


        /*public class Matematica 
        {
            public int Num {  get; set; }

            public void Fatorial(int num)
            {
                this.Num = num;
                int fatorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    fatorial *= i;
                }
                Console.WriteLine($"O fatorial de {num} é {fatorial}");

            }
        }*/

    /*public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        // Construtor que aceita largura e altura
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        // Construtor que usa valores padrão
        public Retangulo() : this(1, 1) // Chama o outro construtor com valores padrão
        {
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }*/

    /*public class Pessoa
    {
        public int Idade { get; set; }

        // Método de instância que aumenta a idade
        public void AumentarIdade()
        {
            Idade++;
        }

        // Método estático que cria uma nova pessoa com idade inicial 0
        public static Pessoa CriarPessoa()
        {
            return new Pessoa { Idade = 0 };
        }
    }*/
}
