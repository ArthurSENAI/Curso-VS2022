using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class VarUsageExample
    {
        public void DemonstrateVarUsage()
        {
            // Exemplo 1: Inferência de Tipo
            var numeroInteiro = 42; // O compilador infere que o tipo é int
            var numeroReal = 3.14; // O compilador infere que o tipo é double
            var texto = "Hello, World!"; // O compilador infere que o tipo é string

            Console.WriteLine($"numeroInteiro: {numeroInteiro}, Tipo: {numeroInteiro.GetType()}");
            Console.WriteLine($"numeroReal: {numeroReal}, Tipo: {numeroReal.GetType()}");
            Console.WriteLine($"texto: {texto}, Tipo: {texto.GetType()}");

            // Exemplo 2: Inferência com Tipos Complexos
            var novaPessoa = new NovaPessoa { Nome = "Alice", Idade = 30 }; // O compilador infere o tipo como NovaPessoa

            Console.WriteLine($"Pessoa Nome: {novaPessoa.Nome}, Idade: {novaPessoa.Idade}");

            // Exemplo 3: Uso com Coleções
            var numbers = new int[] { 1, 2, 3, 4, 5 }; // O compilador infere o tipo como int[]
            var nomes = new List<string> { "Alice", "Bob", "Charlie" }; // O compilador infere o tipo como List<string>

            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Nomes:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            // Exemplo 4: Não pode ser usado sem inicialização
            // var uninitializedVar; // Isto resultará em um erro de compilação, pois o tipo não pode ser inferido sem um valor inicial

            // Exemplo 5: Uso com LINQ
            var query = from n in numbers
                        where n % 2 == 0
                        select n;

            Console.WriteLine("Numeros Pares:");
            foreach (var numeroPar in query)
            {
                Console.WriteLine(numeroPar);
            }
        }
    }

    // Exemplo de classe usada no exemplo
    public class NovaPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

}
