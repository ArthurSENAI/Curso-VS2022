using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class ExercicioOperadoresAritmeticos
    {
        /* 1. Questão: Crie um programa em C# que solicite ao usuário dois números inteiros e 
           calcule a soma desses números. Exiba o resultado com uma mensagem que informe a 
           soma dos dois números. */

        public static void Exercicio1()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = numero1 + numero2;
            Console.WriteLine($"A soma dos números {numero1} e {numero2} é {soma}.");
        }


        /* 2. Questão: Peça ao usuário para inserir dois números inteiros e calcule a diferença entre
           o primeiro e o segundo número. Exiba o resultado com uma mensagem que informe a
           subtração. */
        public static void Exercicio2()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1 - numero2;
            Console.WriteLine($"A diferença entre {numero1} e {numero2} é {diferenca}.");
        }

        /* 3. Questão: Solicite ao usuário para inserir dois números inteiros e calcule a
           multiplicação desses números. Exiba o resultado com uma mensagem que informe a
           multiplicação. */

        public static void Exercicio3()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1 * numero2;
            Console.WriteLine($"A multiplicação entre {numero1} e {numero2} é {diferenca}.");
        }

        /* 4. Questão: Peça ao usuário para inserir dois números inteiros e calcule a divisão do
           primeiro número pelo segundo. Exiba o resultado com uma mensagem que informe a
           divisão. Inclua tratamento para divisão por zero. */
        public static void Exercicio4()
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            double diferenca = numero1 / numero2;
            Console.WriteLine($"A divisão entre {numero1} e {numero2} é {diferenca}.");
        }

        /* 5. Questão: Solicite ao usuário para inserir dois números inteiros e calcule o resto da
           divisão do primeiro número pelo segundo. Exiba o resultado com uma mensagem que
           informe o resto da divisão. */
        public static void Exercicio5()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1 % numero2;
            Console.WriteLine($"o resto entre {numero1} e {numero2} é {diferenca}.");
        }

        /* 6. Questão: Peça ao usuário para inserir um número inteiro e, em seguida, exiba o
           número incrementado em 1. Utilize o operador de incremento ++. */

        public static void Exercicio6()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1++;
            Console.WriteLine($"O numero {numero1} incrementado por 1 é {diferenca}.");
        }

        /* 7. Questão: Solicite ao usuário para inserir um número inteiro e exiba o mesmo número
           decrementado em 1. Utilize o operador de decremento --. */

        public static void Exercicio7()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1--;
            Console.WriteLine($"O numero {numero1} decrementado por 1 é {diferenca}.");
        }

        /* 8. Questão: Crie um programa que solicite ao usuário para inserir dois números inteiros e
           calcule a média desses números. Exiba a média com uma mensagem informativa. */

        public static void Exercicio8() 
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double media = (numero1 + numero2)/2.0;
            Console.WriteLine($"A media dos números {numero1} e {numero2} é {media}.");
        }

        /* 9. Questão: Peça ao usuário para inserir três números inteiros e calcule a soma dos dois
           primeiros números e, em seguida, subtraia o terceiro número do resultado. Exiba o
           resultado com uma mensagem explicativa. */

        public static void Exercicio9()
        {

            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int soma = (numero1 + numero2) - numero3;
            Console.WriteLine($"A soma dos números {numero1} e {numero2}, subtraida pelo numero {numero3} é {soma}.");
        }

        /* 10. Questão: Solicite ao usuário dois números inteiros e calcule o quadrado do primeiro
           número somado ao segundo número. Exiba o resultado com uma mensagem
           explicativa. */

        public static void Exercicio10()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = (numero1*numero1) + numero2;
            Console.WriteLine($"A soma do quadrado do número {numero1} e {numero2} é {soma}.");
        }


        /* 11. Questão: Crie um programa que solicite ao usuário para inserir um valor e exiba o
           dobro desse valor e a metade desse valor. Utilize operadores aritméticos para fazer os
           cálculos. */

        public static void Exercicio11()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int dobro = (numero1 * 2);
            double metade = (numero1 / 2.0);
            Console.WriteLine($"A dobro do número {numero1} é {dobro} e a metade é {metade}.");
        }

        /* 12. Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
           expressão (a + b) * (a - b). Exiba o resultado com uma mensagem informativa. */

        public static void Exercicio12()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double expressao = (numero1 + numero2) * (numero1 - numero2);
            Console.WriteLine($"O resultado da expressao((a + b) * (a - b)) dos números {numero1} e {numero2} é {expressao}.");
        }

        /* 13. Questão: Solicite ao usuário para inserir dois números inteiros e calcule a soma do
           quadrado do primeiro número com o quadrado do segundo número. Exiba o resultado
           com uma mensagem explicativa. */

        public static void Exercicio13()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = (numero1 * numero1) + (numero2 * numero2);
            Console.WriteLine($"A soma dos quadrados dos números {numero1} e {numero2} é {soma}.");
        }

        /* 14. Questão: Crie um programa que solicite ao usuário para inserir um número inteiro e
           calcule o valor do número ao cubo. Exiba o resultado com uma mensagem explicativa. */

        public static void Exercicio14()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int cubo = (numero1 * numero1 * numero1);
            Console.WriteLine($"O cubo do número {numero1} é {cubo}.");

        }

        /* 15. Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
           expressão a * (b + a) / b. Exiba o resultado com uma mensagem informativa. */

        public static void Exercicio15()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int expressao = numero1 * (numero2 + numero1) /  numero2;
            Console.WriteLine($"O resultado da expressao(a * (b + a) / b) dos números {numero1} e {numero2} é {expressao}.");
        }

        /* 16. Questão: Solicite ao usuário para inserir um número inteiro e calcule o quadrado da
           diferença entre o número e 5. Exiba o resultado com uma mensagem explicativa. */

        public static void Exercicio16()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            double diferenca = (numero1 - 5) * (numero1 - 5);
            Console.WriteLine($"o quadrado da diferença entre o número {numero1} e 5 é {diferenca}.");

        }

        /* 17. Questão: Crie um programa que solicite ao usuário dois números inteiros e calcule a
           média aritmética entre eles. Exiba a média com uma mensagem explicativa. */

        public static void Exercicio17()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double media = (numero1 + numero2) / 2.0;
            Console.WriteLine($"A media dos números {numero1} e {numero2} é {media}.");
        }

        /* 18. Questão: Peça ao usuário para inserir um valor em reais e calcule o valor em dólares,
           assumindo uma taxa de câmbio fixa de 5.0 reais por dólar. Exiba o resultado com uma
           mensagem explicativa. */

        public static void Exercicio18()
        {
            Console.Write("Digite o valor em real: R$ ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            double convercao = (numero1) / 5.0;
            Console.WriteLine($"O valor em dolar de R$ {numero1} é US${convercao}.");
        }

        /* 19. Questão: Solicite ao usuário para inserir a quantidade de dias e calcule a quantidade
           total de horas. Exiba o resultado com uma mensagem explicativa. */

        public static void Exercicio19()
        {
            Console.Write("Digite o numero de dias: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int qtHoras = (numero1) * 24;
            Console.WriteLine($"A quantidade de horas em {numero1} é {qtHoras}.");

        }

        /* 20. Questão: Crie um programa que peça ao usuário para inserir a quantidade de horas e
           minutos e calcule o total em minutos. Exiba o resultado com uma mensagem
           explicativa. */

        public static void Exercicio20()
        {
            Console.Write("Digite quantas horas: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantos minutos: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int qtMinutos = (numero1 * 60) + numero2;
            Console.WriteLine($"O total de minutos em {numero1} horas e {numero2} minutos é {qtMinutos} minutos.");
        }
    }
}