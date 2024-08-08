using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class OperadorTernario
    {
        public static void Demonstrarternario()
        {
            int a = 10;
            int b = 20;

            // Usando o operador ternario para encontrar o maior valor entre a e b
            int maior = (a > b) ? a : b;
            Console.WriteLine($"O maior valor entre {a} e {b} é {maior}");

            // Outro exemplo: Verificar se um numero épar ou impar
            int numero = 15;
            string resultado = (numero % 2 == 0) ? "par" : "impar";
            Console.WriteLine($"O numero {numero} é {resultado}");

            /*
             if(numero % 2 == 0)
            {
                Console.WriteLine("par")
            }
            else
            {
                Console.WriteLine("impar")
            }
             
             */

            // Exemplo com uma string: Verificar se um nome está vazio
            string nome = "";
            string mensagem = (nome == "") ? "Nome vazio" : $"Nome: {nome}";
            string mensagem2 = (!string.IsNullOrEmpty(nome)) ? "Nome valido" : "Nome inválido";

            Console.WriteLine(mensagem);
            Console.WriteLine(mensagem2);
        }
    }
}
