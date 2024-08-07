using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class OperadoresAtribuicao
    {
        // Metodo para demonstrar o operador de atribuição simples (=)
        public static void AtribuicaoSimples()
        {
            int a = 10;
            Console.WriteLine($"Valor de a apos atribuição: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com adição (+=)
        public static void AtribuicaoSoma()
        {
            int a = 10;
            a += 5; // Equivalente a a = a + 5
            Console.WriteLine($"Valor de a apos a operação +=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com subtração (-=)
        public static void AtribuicaoSubtracao()
        {
            int a = 10;
            a -= 5; // Equivalente a a = a - 5
            Console.WriteLine($"Valor de a apos a operação -=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com multiplicação (*=)
        public static void AtribuicaoMultiplicacao()
        {
            int a = 10;
            a *= 5; // Equivalente a a = a * 5
            Console.WriteLine($"Valor de a apos a operação *=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com divisão (/=)
        public static void AtribuicaoDivisao()
        {
            int a = 10;
            a /= 5; // Equivalente a a = a / 5
            Console.WriteLine($"Valor de a apos a operação /=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com modulo (%=)
        public static void AtribuicaModulo()
        {
            int a = 10;
            a %= 5; // Equivalente a a = a % 5
            Console.WriteLine($"Valor de a apos a operação %=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com AND (&=)
        public static void AtribuicaAnd()
        {
            int a = 12; // Binario: 1100
            a &= 7; // Binario: 0111
                    // Resultado: 0100(4 em decimal)
            Console.WriteLine($"Valor de a apos a operação &=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com OR (|=)
        public static void AtribuicaoOr()
        {
            int a = 12; // Binario: 1100
            a &= 5; // Binario: 0101
                    // Resultado: 1101(13 em decimal)
            Console.WriteLine($"Valor de a apos a operação |=: {a}");
        }

        // Metodo para demonstrar o operador de atribuição composto com OR (^=) 
        public static void AtribuicaoXor()
        {
            int a = 12; // Binario: 1100
            a ^= 6; // Binario: 0110
                    // Resultado: 1010(10 em decimal)
            Console.WriteLine($"Valor de a apos a operação ^=: {a}");
        }

        // Metodo para demonstrar o operador de atribuicao para a esquerda (<<=)  em C#
        public static void AtribuicaDeslocamentoEsquerda()
        {
            int a = 4; // BInario: 0100
            a <<= 2; // Desloca 2 bits á esquerda: 0001 0000 (16 em decimal)
            Console.WriteLine($"Valor de a apos a operação <<= 2: {a}");
        }

        // Metodo para demonstrar o operador de atribuicao para a direita (>>)  em C#
        public static void AtribuicaDeslocamentoDireta()
        {
            int a = 4; // BInario: 0001 0000
            a >>= 2; // Desloca 2 bits á direita: 0000 0100 (16 em decimal)
            Console.WriteLine($"Valor de a apos a operação >>= 2: {a}");
        }
    }
}