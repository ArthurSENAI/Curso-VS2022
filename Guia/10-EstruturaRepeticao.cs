using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class EstruturaRepeticao
    {
        public static void DemonstrarRepeticoes()
        {
            // 1. Estrutura de repetição 'for'
            Console.WriteLine("Estrutura for:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteração {i}");
            }

            //2. Estrutura de repetição 'while'
            Console.WriteLine("\nEstrutura while:");
            int contadorWhile = 0;
            while (contadorWhile < 5)
            {
                Console.WriteLine($"Iteração {contadorWhile}");
                contadorWhile++;
            }

            //3. Estrutura de repetição 'd0-while'
            Console.WriteLine("\nEstrutura do-while:");
            int contadorDoWhile = 0;
            do
            {
                Console.WriteLine($"Iteração {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorWhile < 5);

            //4. Estrutura de repetição 'foreach'
            Console.WriteLine("\nEstrutura foreach:");
            string[] frutas = { "Maça", "Banana", "Laranja", "Uva" };
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
               
            }
        }
    }
}
