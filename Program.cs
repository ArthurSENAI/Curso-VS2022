using CursoCSharp.Guia;
using CursoCSharp.Exercicios;

var ex = new Matematica();
ex.Fatorial(6);

// Usando o construtor que aceita parâmetros
Retangulo retangulo1 = new Retangulo(5, 10);
Console.WriteLine($"Área do retângulo 1: {retangulo1.CalcularArea()}");

// Usando o construtor com valores padrão
Retangulo retangulo2 = new Retangulo();
Console.WriteLine($"Área do retângulo 2: {retangulo2.CalcularArea()}");

// Criando uma nova pessoa usando o método estático
Pessoa pessoa = Pessoa.CriarPessoa();
Console.WriteLine($"Idade inicial: {pessoa.Idade}");

// Aumentando a idade da pessoa
pessoa.AumentarIdade();
Console.WriteLine($"Idade após aumento: {pessoa.Idade}");
