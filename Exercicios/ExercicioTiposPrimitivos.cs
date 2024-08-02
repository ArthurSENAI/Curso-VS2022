using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class ExercicioTiposPrimitivos
    {
        public static void Exercicio1()
        {
            //armazenar o sobrenome do usuário e exibi - lo junto com o nome:
            string? nome;
            string? sobrenome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"O seu nome completo é {nome} {sobrenome}");
        }

        public static void Exercicio2()
        {
            //Peça ao usuário para inserir a idade e exiba o nome e a idade
            string? nome;
            int idade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O seu nome é {nome}, e a sua idade é {idade}");
        }

        public static void Exercicio3()
        {
            //armazenar o sobrenome do usuário e exibi - lo junto com o nome:
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sua cidade:");
            cidade = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a sua cidade é {cidade}");
        }

        public static void Exercicio4()
        {
            //Armazene o nome do usuário em maiúsculas e exiba-o:
            string? nome;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine().ToUpper();
            Console.WriteLine($"O seu nome em maiusculo é {nome}");
        }

        public static void Exercicio5()
        {
            //Armazene o nome do usuário em maiúsculas e exiba-o:
            string? nome;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine().ToLower();
            Console.WriteLine($"O seu nome em minusculo é {nome}");
        }

        public static void Exercicio6()
        {
            //Peça ao usuário para inserir seu nome e idade, depois exiba ambos em umaúnica linha:
            string? nome;
            int idade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O seu nome é {nome}, e a sua idade é {idade}");
        }

        public static void Exercicio7()
        {
            //Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sua cidade de nascimento:");
            cidade = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a sua cidade de nascimento é {cidade}");
        }

        public static void Exercicio8()
        {
            //Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:
            string? nome;
            string? profissao;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sua profissao:");
            profissao = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a sua profissao é {profissao}");
        }

        public static void Exercicio9()
        {
            //Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:
            string? nome;
            string? pais;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu pais:");
            pais = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a seu pais de origem é {pais}");
        }

        public static void Exercicio10()
        {
            //Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:
            string? nome;
            string? numero;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu numero favorito:");
            numero = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a seu numero favorito é {numero}");
        }

        public static void Exercicio11()
        {
            //Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:
            string? nome;
            string? hobby;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu hobby:");
            hobby = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a seu hobby é {hobby}");
        }

        public static void Exercicio12()
        {
            //Peça ao usuário para inserir seu nome e cor favorita, depois exiba ambos:
            string? nome;
            string? cor;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sua cor preferida:");
            cor = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a sua cor preferida {cor}");
        }

        public static void Exercicio13()
        {
            //Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:
            string? nome;
            string? filme;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu filme favorito:");
            filme = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e seu filme favorito {filme}");
        }

        public static void Exercicio14()
        {
            //Peça ao usuário para inserir seu nome e gênero musical favorito, depois exiba ambos:
            string? nome;
            string? gMusical;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu genero musical favorito:");
            gMusical = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e o seu genero musical favorito {gMusical}");
        }

        public static void Exercicio15()
        {
            //Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:
            string? nome;
            string? animal;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu animal favorito:");
            animal = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e o seu animal favorito {animal}");
        }

        public static void Exercicio16()
        {
            //Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:
            string? nome;
            string? esporte;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu esporte favorito:");
            esporte = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e o seu esporte favorito {esporte}");
        }

        public static void Exercicio17()
        {
            //Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:
            string? nome;
            string? comida;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua comida favorita:");
            comida = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a sua comida favorita {comida}");
        }

        public static void Exercicio18()
        {
            //Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:
            string? nome;
            string? banda;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua banda favorita:");
            banda = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e a sua banda favorita {banda}");
        }

        public static void Exercicio19()
        {
            //Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:
            string? nome;
            string? livro;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu livro favorito:");
            livro = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e o seu livro favorito {livro}");
        }

        public static void Exercicio20()
        {
            //Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:
            string? nome;
            string? lema;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite um lema de vida:");
            lema = Console.ReadLine();
            Console.WriteLine($"O seu nome é {nome} e um lema de vida {lema}");
        }
    }
}

