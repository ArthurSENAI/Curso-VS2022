using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    internal class Conversao
    {
        public static void DemonstrarConversões()
        {
            // 1. Conversão Implicita (Implicit Conversion)
            int numInt = 100;
            long numLong = numInt; // Conversao implivita de int para long
            Console.WriteLine($"Conversão implicita de int  pra long: {numLong}");

            // 2. Conversão Explicita (Casting)
            double numDouble = 1234.56;
            int numCast = (int)numDouble; // Conversao explicita de double para int (perda de dados decimais)
            Console.WriteLine($"Conversão explicita de double para int (cast): {numCast}");

            // 3. Conversao com Convert
            string numeroString = "456";
            int numConvert = Convert.ToInt32(numeroString); // Conversao de string para int usando COnvert
            Console.WriteLine($"Conversão de string para int usando Convert: {numConvert}");

            // 4. Conversao com Parse
            string numeroString2 = "789";
            int numParse = int.Parse(numeroString2); // Conversao de string para int usando Parse
            Console.WriteLine($"Conversão de string para int usando Parse: {numConvert}");

            // 5. Uso de TryParse para conversão segura
            string numeroInvalido = "abc";
            bool conversaoSucesso = int.TryParse(numeroInvalido, out int numTryParse);
            Console.WriteLine($"Conversao com TryParse (sucesso): {conversaoSucesso}, valor: {numTryParse}");

            // 6. Conversao de tipos incompativeis
            object obj = 1234; // Boxing
            int numUnboxed = (int)obj; // Unboxing (conversao explicita)
            Console.WriteLine($"Unboxing de object para obj: {numUnboxed}");

            // 7. Conversao de tipo numericos para string
            int numero = 42;
            string numString = numero.ToString(); // Conversao de int para string
            Console.WriteLine($"Conversao de int para string: {numString}");

        }
    }
}
