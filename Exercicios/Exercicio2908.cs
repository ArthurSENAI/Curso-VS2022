using CursoCSharp.Guia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    /*public class Exercicio2908
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

    public class PesquisaProdutos
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

    }

}
