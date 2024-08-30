using CursoCSharp.Guia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    /*public class Exercicio1
    {
        public void ExibirConsulta()
        {
            var Pessoas = new List<PessoasLINQ2>
            {
                new PessoasLINQ2 { Nome = "Alice", Idade = 30 },
                new PessoasLINQ2 { Nome = "Bob", Idade = 25 },
                new PessoasLINQ2 { Nome = "Charlie", Idade = 35 },
                new PessoasLINQ2 { Nome = "Diana", Idade = 40 }
            };

            var pessoasIniciaComAEIdadeAcimaDe25 = Pessoas.Where(p => p.Nome.StartsWith("A") && p.Idade > 25);

            foreach (var pessoa in pessoasIniciaComAEIdadeAcimaDe25) 
            {
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
            }
        }
    }

    public class PessoasLINQ2
    {
        public string? Nome;
        public int Idade;

    }*/

    /*public class Exercicio2
    {
        public void ExibirConsulta()
        {
            var Produtos = new List<Produtos>
            {
                new Produtos { Nome = "Arroz", Preco = 20.00 },
                new Produtos { Nome = "Cafe", Preco = 25.00 },
                new Produtos { Nome = "Feijão", Preco = 10.00 },
                new Produtos { Nome = "Macarrão", Preco = 7.00 },
                new Produtos { Nome = "Alcatra", Preco = 35.00 },
                new Produtos { Nome = "Bandeja de Ovo", Preco = 18.00 },
                new Produtos { Nome = "Sabao em po", Preco = 12.00 },
            };

            var precoMedio = Produtos.Average(p => p.Preco);
            var precoSuperiorAMedia = Produtos.Where(p => p.Preco > precoMedio);

            foreach (var produto in precoSuperiorAMedia)
            {
                Console.WriteLine($"{produto.Nome}, R${produto.Preco:F2}");
            }
        }
    }

    public class Produtos
    {
        public string? Nome;
        public double Preco;

    }*/

    /*    public class Exercicio3
        {
            public void ExibirConsulta()
            {
                var Pessoas = new List<PessoasLINQ2>()
                {
                    new PessoasLINQ2 { Nome = "Arthur", Idade = 29 },
                    new PessoasLINQ2 { Nome = "Tiago", Idade = 21 },
                    new PessoasLINQ2 { Nome = "Davi", Idade = 22 },
                    new PessoasLINQ2 { Nome = "Leonardo", Idade = 19},
                    new PessoasLINQ2 { Nome = "Lia", Idade = 20},
                    new PessoasLINQ2 { Nome = "Suelen", Idade = 19},
                    new PessoasLINQ2 { Nome = "Zelita", Idade = 19},
                    new PessoasLINQ2 { Nome = "Marcos", Idade = 19},
                    new PessoasLINQ2 { Nome = "Ruan", Idade = 18},
                };

                var pessoaOrdemReversa = Pessoas.OrderByDescending(p => p.Nome).ToList();

                foreach(var pessoa in pessoaOrdemReversa)
                {
                    Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
                }
            }

        }

        public class PessoasLINQ2
        {
            public string? Nome;
            public int Idade;

        }*/

    /*public class NovaPessoa
    {
        public int Idade;
        public string? Nome;
        public string? Cidade;
    }
    public class Exercicio4
    {
        public void ExibirMetodo()
        {
            var pessoasList = new List<NovaPessoa>
            {
              new NovaPessoa{ Idade = 23, Nome = "Alice", Cidade = "São Paulo" },
              new NovaPessoa{ Idade = 19, Nome = "Bob", Cidade = "Rio de Janeiro" },
              new NovaPessoa{ Idade = 25, Nome = "Charlie", Cidade = "Belo Horizonte" },
              new NovaPessoa{ Idade = 30, Nome = "Diana", Cidade = "Fortaleza"},
              new NovaPessoa{ Idade = 28, Nome = "Eduardo", Cidade = "São Paulo" },
              new NovaPessoa{ Idade = 22, Nome = "Francisco", Cidade = "Rio de Janeiro" },
              new NovaPessoa{ Idade = 26, Nome = "Gabriel", Cidade = "Belo Horizonte" },
              new NovaPessoa{ Idade = 31, Nome = "Hugo", Cidade = "Fortaleza"}
            };

            var pessoasNovasPorCidade = pessoasList.GroupBy(p => p.Cidade).Select(g => g.OrderBy(p => p.Idade).First()).ToList();

            Console.WriteLine($"Pessoa mais nova por Cidade: ");
            foreach (var pessoa in pessoasNovasPorCidade)
            {
                Console.WriteLine($"{pessoa.Nome} de {pessoa.Cidade}");
            }
        }
    }*/

    /*public class Livros
    {
        public string? Titulo;
        public string? Autor;
        public int AnoPublicacao;
    }
    public class Exercicio5
    {
        public void ExibirMetodo()
        {
            var LivrosList = new List<Livros>
            {
                new Livros{ Titulo = "Se Houver o Amanhã", Autor = "Sidney Sheldon", AnoPublicacao = 1985},
                new Livros{ Titulo = "O reverso da Medalha", Autor = "Sidney Sheldon", AnoPublicacao = 1982},
                new Livros{ Titulo = "O Outro Lado da Meia Noite", Autor = "Sidney Sheldon", AnoPublicacao = 1973},
                new Livros{ Titulo = "Me Conte seu Sonho", Autor = "Sidney Sheldon", AnoPublicacao = 1998},
                new Livros{ Titulo = "A Herdeira", Autor = "Sidney Sheldon", AnoPublicacao = 1977},
                new Livros{ Titulo = "Lembranças da Meia Noite", Autor = "Sidney Sheldon", AnoPublicacao = 1990},
            };

            var livrosApos2000 = LivrosList.Where(l => l.AnoPublicacao > 1980).OrderBy(x => x.AnoPublicacao).ToList();

            Console.WriteLine($"Livros publicados após 1980: ");
            foreach (var livro in livrosApos2000)
            {
                Console.WriteLine($"{livro.Titulo} - {livro.Autor} - {livro.AnoPublicacao}");
            }
        }
    }*/


}
