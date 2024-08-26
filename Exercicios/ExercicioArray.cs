/* 1.	Criando e Inicializando um Array
Crie um array de inteiros chamado numeros com capacidade para 5 elementos. 
Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.
2.	Acessando Elementos de um Array
Dado o array int[] valores = {1, 3, 5, 7, 9};, 
imprima o terceiro elemento do array.
3.	Alterando Valores em um Array
Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". 
Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array.
4.	Calculando a Soma dos Elementos de um Array
Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. 
Calcule e imprima a soma de todos os elementos do array.
5.	Procurando um Elemento em um Array
Dado o array int[] numeros = {5, 10, 15, 20, 25};, 
escreva um código que verifique se o número 15 está presente no array e 
imprima uma mensagem confirmando.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class ArrayExercicio
    {
        /* 1.	Criando e Inicializando um Array
            Crie um array de inteiros chamado numeros com capacidade para 5 elementos. 
            Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos. */

        public static void Exercicio1()
        {
            int[] numeros = new int[5] { 2, 4, 6, 8, 10 };
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"os numeros foram: {numeros[i]}");
            }
        }

        /* 2.	Acessando Elementos de um Array
            Dado o array int[] valores = {1, 3, 5, 7, 9};, 
            imprima o terceiro elemento do array. */

        public static void Exercicio2()
        {
            int[] valores = { 1, 3, 5, 7, 9 };
            Console.WriteLine($"o terceiro elemento do array valores foi: {valores[2]}");
        }

        /* 3.    Alterando Valores em um Array
            Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". 
            Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array. */

        /* public static void Exercicio3()
        {
            List<string> nomes = new List<string> { "Ana", "Bruno", "Carla" };
            foreach(var nome in nomes)
            {
                Console.WriteLine($"O nome na posição {nomes.IndexOf(nome)} foi: {nome}");
            }
            int indiceBruno = nomes.IndexOf("Bruno");
            nomes.Insert(indiceBruno, "Beto");
            nomes.Remove("Bruno");
            foreach(var nome in nomes)
            {
                Console.WriteLine($"O nome na posição {nomes.IndexOf(nome)} foi: {nome}");
            }
        } */

        public static void Exercicio3()
        {
            string[] nomes = { "Ana", "Bruno", "Carla" };
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == "Bruno")
                {
                    nomes[i] = "Beto";
                }
            }
            foreach (var nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }
        }

        /* 4.	Calculando a Soma dos Elementos de um Array
            Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. 
            Calcule e imprima a soma de todos os elementos do array. */
        public static void Exercicio4()
        {
            int[] notas = { 7, 8, 9, 10, 6 };
            int soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            Console.WriteLine($"A soma das notas foi: {soma}");
        }

        /* 5.	Procurando um Elemento em um Array
            Dado o array int[] numeros = {5, 10, 15, 20, 25};, 
            escreva um código que verifique se o número 15 está presente no array e 
            imprima uma mensagem confirmando. */
        public static void Exercicio5()
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            bool contemQuinze = numeros.Contains(15);
            if (contemQuinze)
            {
                Console.WriteLine($"O array contém o número 15: {contemQuinze}");
            }
            else
            {
                Console.WriteLine($"O array não contém o número 15: {contemQuinze}");
            }

        }

    }
}