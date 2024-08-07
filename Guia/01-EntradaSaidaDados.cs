using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class EntradaSaidaDados
    {
        public static void LerArmazenar()
        {
            string? nome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            if (nome == "")
            {
                Console.WriteLine("Nenhum nome foi digitado");
            }
            else
            {
                Console.WriteLine($"Seu nome é: {nome}!");
            }

        }
    }
}
