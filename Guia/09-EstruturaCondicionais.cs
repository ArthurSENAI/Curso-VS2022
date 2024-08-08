using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public static class EstruturaCondicionais
    {
        public static void DemostrarCondicional()
        {
            int numero = 25;

            // Exemplo de if-else
            if (numero < 10)
            {
                Console.WriteLine("O número é menor que 10");
            }
            else if (numero < 20)
            {
                Console.WriteLine("O número é menor que 20");
            }
            else
            {
                Console.WriteLine("O número é 20 ou maior");
            }

            // Exemplor de Switch
            string diaSemana = "Segunda-feira";

            switch (diaSemana)
            {
                case "Domingo":
                    Console.WriteLine("Hoje é Domingo");
                    break;
                case "Segunda-feira":
                    Console.WriteLine("Hoje é Segunda-feira");
                    break;
                case "Terça-feira":
                    Console.WriteLine("Hoje é Terça-feira");
                    break;
                case "Quarta-feira":
                    Console.WriteLine("Hoje é Quarta-feira");
                    break;
                case "Quinta-feira":
                    Console.WriteLine("Hoje é Quinta-feira");
                    break;
                case "Sexta-feira":
                    Console.WriteLine("Hoje é Sexta-feira");
                    break;
                case "Sabado":
                default:
                    Console.WriteLine("Dia invalido");
                    break;
            }
        }
    }
}
