using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    // Definição de uma classe chamada Pessoa
    public class Pessoa
    {
        // Atributos (variáveis de instância)
        public string Nome;
        public int Idade;

        // Membro Estático (variável de classe)
        public static int NumeroDePessoas;

        // Construtor (um método especial para criar objetos)
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            NumeroDePessoas++;
        }

        // Método para exibir informações da pessoa
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

        // Método Estático (pertence à classe, não à instância)
        public static void ExibirNumeroDePessoas()
        {
            Console.WriteLine($"Número de pessoas criadas: {NumeroDePessoas}");
        }
    }

    // Classe principal para executar os exemplos
    /* public class ExemploClassesObjetos
    {
        public static void Main(string[] args)
        {
            // 1. Criando Objetos (Instanciando a classe Pessoa)
            Pessoa pessoa1 = new Pessoa("Alice", 30);
            Pessoa pessoa2 = new Pessoa("Bob", 25);

            // 2. Usando Métodos de Instância (Métodos não estáticos)
            pessoa1.ExibirInformacoes();
            pessoa2.ExibirInformacoes();

            // 3. Usando Método Estático (Pertence à Classe, não à instância)
            Pessoa.ExibirNumeroDePessoas();

            // 4. Membros de Instância vs. Membros Estáticos
            Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
            Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
            Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");
        }
    } */
}