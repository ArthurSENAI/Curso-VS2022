/* 1.	Variável Local em um Método
Escreva um método chamado CalculaSoma que declare uma variável local int soma e 
calcule a soma de dois números passados como parâmetros.
A variável soma deve estar acessível apenas dentro deste método.
2.	Variável Global em uma Classe
Crie uma classe chamada Carro com uma variável global string marca. 
No método Main, instancie um objeto Carro, defina a marca do carro como "Toyota" e imprima a marca.
3.	Conflito de Escopo
Escreva um método onde você declare uma variável local com o mesmo nome de uma variável global da classe. 
Mostre como acessar ambas as variáveis no mesmo método.
4.	Variável Local dentro de um Bloco Condicional
Escreva um código onde uma variável int x seja declarada dentro de um bloco if. 
Tente acessar essa variável fora do bloco if e observe o que acontece.
5.	Alterando o Valor de uma Variável Global
Crie uma variável global int contador em uma classe.
No método Main, altere o valor de contador dentro de um loop for e depois imprima o valor final de contador.
6.	Capturando uma Exceção de Conversão de Tipo
Tente converter uma string não numérica para um inteiro usando int.Parse. 
Use try-catch para capturar a exceção e imprima uma mensagem apropriada.
7.	Lançando Exceções
Escreva um método que recebe um número inteiro. 
Se o número for negativo, lance uma ArgumentException. 
Capture a exceção no método Main e imprima uma mensagem apropriada.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class EscopoVariaveisExercicio
    {
        /* 1.	Variável Local em um Método
            Escreva um método chamado CalculaSoma que declare uma variável local int soma e 
            calcule a soma de dois números passados como parâmetros. */
        public void CalculaSoma(int num1, int num2)
        {
            int soma = num1 + num2;
            Console.WriteLine($"O resultado da soma de {num1} + {num2} = {soma}");
        }

        /* 2.	Variável Global em uma Classe
            Crie uma classe chamada Carro com uma variável global string marca. 
            No método Main, instancie um objeto Carro, defina a marca do carro como "Toyota" e imprima a marca. */
        public class Carro
        {
            public string? marca;
            public void Escrever()
            {
                Console.WriteLine($"Marca: {marca}");
            }

            /* 3.	Conflito de Escopo
            Escreva um método onde você declare uma variável local com o mesmo nome de uma variável global da classe. 
            Mostre como acessar ambas as variáveis no mesmo método. */
            public void ConflitoEscopo()
            {
                string? marca;
                marca = "Fiat";
                Console.WriteLine($"Variável local: {marca}");

            }

        }

        /* 4.	Variável Local dentro de um Bloco Condicional
            Escreva um código onde uma variável int x seja declarada dentro de um bloco if. 
            Tente acessar essa variável fora do bloco if e observe o que acontece. */
        public void XCondicional(int y)
        {
            if (y > 3)
            {
                int x = y + 5;
                Console.WriteLine($"Valor de x: {x}");
            }
            else
            {
                Console.WriteLine("Valor de x não é acessavel.");
            }

        }

        /* 5.	Alterando o Valor de uma Variável Global
          Crie uma variável global int contador em uma classe.
          No método Main, altere o valor de contador dentro de um loop for e depois imprima o valor final de contador.*/

        public class Contador
        {
            public int contador = 0;
            public void IncrementarPor10(int i)
            {
                Console.Write($"O valor incrementado {i} vezes por 10.");
                while (i - 1 >= 0)
                {
                    contador += 10;
                    i--;
                }
                Console.Write($" O total atual é {contador}");
            }
        }

        /* 6.	Capturando uma Exceção de Conversão de Tipo
            Tente converter uma string não numérica para um inteiro usando int.Parse. 
            Use try-catch para capturar a exceção e imprima uma mensagem apropriada. */

        public void CapturarExcecao(string converterNum)
        {
            try
            {
                int num = int.Parse(converterNum);
                Console.WriteLine($"Número convertido: {num}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ocorreu um erro de conversão: {ex.Message}");
            }
        }

        /* 7.	Lançando Exceções
            Escreva um método que recebe um número inteiro. 
            Se o número for negativo, lance uma ArgumentException. 
            Capture a exceção no método Main e imprima uma mensagem apropriada. */

        public void NumeroPositivo(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("Número não pode ser negativo.");
            }
            Console.WriteLine($"Número válido: {numero}");
        }
    }
}