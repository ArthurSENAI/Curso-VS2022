using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharp.Exercicios
{
    /*    Exercícios Teóricos
    Definição e Propósito:
        Pergunta: O que significa a palavra-chave var em C# e qual é o seu propósito?
        R. É a palavra-chave(var) que é usado para declarar variavel sem a necessidade de passar tipo. Um dos proposito é a criação dinamica de objetos sem a necissade da verbosidade da classe.
    Inferência de Tipo:
        Pergunta: Como o compilador determina o tipo de uma variável quando você usa var?
        R. Dinamicamente, pois a esse tipo de variavel consegue inferir tipo da variavel atraves do valor atribuido a ela.
    Regras e Restrições:
        Pergunta: Quais são as restrições no uso da palavra-chave var em C#?
        R. Declaração e iniciação na mesma instrução. Não pode ser inicializado como nulo ou anonimo. Não pode ser usado em campos  de classe.
    Diferença entre var e Tipos Explícitos:
        Pergunta: Qual é a diferença entre usar var e declarar uma variável com um tipo explícito?
        R. A var se tipa automaticamente, já um tipo explicito só aceita valores atribuidos que são do mesmo tipo da variavel.
    Declaração de Variáveis com var:
        Exercício: Declare uma variável de cada um dos seguintes tipos usando var e atribua a elas valores apropriados.Depois, exiba o tipo da variável usando GetType() para confirmar a inferência do tipo.
    Utilizando var em Métodos de LINQ:
        Exercício: Crie uma lista de inteiros e use um método LINQ para ordenar a lista em ordem crescente.Declare a variável que armazena o resultado usando var.
    Declaração de Variáveis com Tipos Complexos:
        Exercício: Declare uma variável var para um tipo complexo, como um Dictionary ou uma instância de uma classe personalizada.Mostre como a inferência de tipo funciona com tipos mais complexos.
    Trabalhando com Tipos Anônimos:
        Exercício: Crie um tipo anônimo usando var para armazenar informações de uma pessoa (nome e idade) e exiba essas informações.*/
    public class Exercicio2808
    {
        //Exercício: Declare uma variável de cada um dos seguintes tipos usando var e atribua a elas valores apropriados.
        //Depois, exiba o tipo da variável usando GetType() para confirmar a inferência do tipo.

        public static void DescobrirTipo()
        {
            var inteiro = 10;
            Console.WriteLine($"O tipo da variável inteiro é: {inteiro.GetType()}");
        }

        //Exercício: Crie uma lista de inteiros e use um método LINQ para ordenar a
        //lista em ordem crescente.Declare a variável que armazena o resultado usando var.
        public void OrdenarListaCrescente(List<int> numeros)
        {
            // Ordena a lista usando LINQ
            var listaOrdenada = from numero in numeros
                                orderby numero
                                select numero;

            // Converte o resultado para uma lista e exibe
            Console.WriteLine("Lista ordenada: " + string.Join(", ", listaOrdenada));
        }
        

    }

    public class PessoaLINQ
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }




}
