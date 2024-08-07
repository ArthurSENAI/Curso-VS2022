using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public static class OperadoresAritmeticos
    {
        public static void Soma()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Soma é: {n1 + n2}");

        }

        public static void Divisao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Divisao é: {n1 / n2}");

        }

        public static void Subtracao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Subtraçao é: {n1 - n2}");

        }

        public static void Multiplicacao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A Multiplicação é: {n1 * n2}");

        }
        public static void Resto()
        {
            int n1 = 11, n2 = 3;
            Console.WriteLine($"O Resto é: {n1 % n2}");
        }

        public static void Incremento()
        {
            int n1 = 1;
            Console.WriteLine($"O Incremento é: {n1++}");
        }

        public static void Decremento()
        {
            int n1 = 4;
            Console.WriteLine($"O Decremento é: {n1--}");
        }
    }
}