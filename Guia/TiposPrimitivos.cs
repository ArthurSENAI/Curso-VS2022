using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public static class TiposPrimitivos
    {
        public static void ImprimirTipos()
        {
            // Tipo inteiro de 8 bits com sinal
            sbyte SByte = -128; // Valores variam de -128 a 127
            Console.WriteLine($"sbyte: {SByte}");

            // Tipo inteiro de 8 bits sem sinal
            byte variavelByte = 255; // Valores variam de 0 a 255
            Console.WriteLine($"byte: {variavelByte}");

            // Tipo inteiro de 16 bits com sinal
            short variavelShort = -32768; // Valores variam de -32768 a 32767
            Console.WriteLine($"short: {variavelShort}");

            // Tipo inteiro de 16 bits sem sinal
            ushort variavelUShort = 65535; // Valores variam de 0 a 65535
            Console.WriteLine($"ushort: {variavelUShort}");

            // Tipo inteiro de 32 bits com sinal
            int variavelInt = -2147483648; // Valores variam de -2147483648 a 2147483647
            Console.WriteLine($"int: {variavelInt}");

            // Tipo inteiro de 32 bits sem sinal
            uint variavelUInt = 4294967295; // Valores variam de 0 a 4294967295
            Console.WriteLine($"uint: {variavelUInt}");

            // Tipo inteiro de 64 bits com sinal
            long variavelLong = -9223372036854775808; // Valores variam de -9223372036854775808 a 9223372036854775807
            Console.WriteLine($"long: {variavelLong}");

            // Tipo inteiro de 64 bits sem sinal
            ulong variavelULong = 18446744073709551615; // Valores variam de 0 a 18446744073709551615
            Console.WriteLine($"ulong: {variavelULong}");

            // Tipo de ponto flutuante de 32 bits
            float variavelFloat = 3.14f; // Valores variam de 1,5 x10^-45 a 3.14 x 10^38, pre
            Console.WriteLine($"float: {variavelFloat}");

            // Tipo de ponto flutuante de 64 bits
            double variavelDouble = 3.141592653589793; // Valores variam de 5.0 x10^-324 a 
            Console.WriteLine($"double: {variavelDouble}");

            // Tipo decimal de 128 bits, usado para valores monetários e financeiros
            decimal variavelDecimal = 79228162514264337593543950335M; // 
            Console.WriteLine($"decimal: {variavelDecimal}");

            // Tipo de caractere Unicode de 16 bits
            char variavelChar = 'A'; // Valores  variam de '\u0000' a '\uffff'
            Console.WriteLine($"char: {variavelChar}");

            // Tipo booleano que pode ser verdadeiro ou falso
            bool variavelBool = true; // Valores são true ou false
            Console.WriteLine($"bool: {variavelBool}");

            // Tipo de valor nulo
            object variavelObject = null; // Pode conter qualquer tipo de valor
            Console.WriteLine($"object: {variavelObject}");

            // Tipo string, sequencia de caracteres Unicode
            string variavelString = "Olá, Mundo!"; // Uma cadeia de caracteres
            Console.WriteLine($"string: {variavelString}");
        }
    }
}
