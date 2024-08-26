/* 1.	Criando e Adicionando Elementos em uma List
Crie uma List<string> chamada frutas. 
Adicione as frutas "Maçã", "Banana", "Laranja" e 
imprima todos os elementos da lista.
2.	Removendo um Elemento de uma List
Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5. 
Remova o número 3 da lista e depois imprima os elementos restantes.
3.	Acessando um Elemento Específico em uma List
Dada a List<string> chamada cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"}, 
imprima a segunda cidade da lista.
4.	Contando Elementos em uma List
Crie uma List<string> chamada animais e adicione os valores "Cachorro", "Gato", "Coelho". 
Escreva um código que imprima quantos elementos existem na lista.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class ListExercicio
    {
        /* 1.	Criando e Adicionando Elementos em uma List
        Crie uma List<string> chamada frutas. 
        Adicione as frutas "Maçã", "Banana", "Laranja" e 
        imprima todos os elementos da lista.*/

        public static void Exercicio1()
        {
            List<string> frutas = new List<string>();
            frutas.Add("Maçã");
            frutas.Add("Banana");
            frutas.Add("Laranja");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

        }

        /* 2.	Removendo um Elemento de uma List
            Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5. 
            Remova o número 3 da lista e depois imprima os elementos restantes. */

        public static void Exercicio2()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            numeros.Remove(3);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }

        /* 3.	Acessando um Elemento Específico em uma List
            Dada a List<string> chamada cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"}, 
            imprima a segunda cidade da lista. */

        public static void Exercicio3()
        {
            List<string> cidades = new List<string> { "São Paulo", "Rio de Janeiro", "Belo Horizonte" };
            Console.WriteLine($"A segunda cidade é: {cidades[1]}");
        }


        /* 4.	Contando Elementos em uma List
            Crie uma List<string> chamada animais e adicione os valores "Cachorro", "Gato", "Coelho". 
            Escreva um código que imprima quantos elementos existem na lista. */

        public static void Exercicio4()
        {
            List<string> animais = new List<string> { "Cachorro", "Gato", "Coelho" };
            Console.WriteLine($"Existem {animais.Count} animais na lista.");
        }


    }
}