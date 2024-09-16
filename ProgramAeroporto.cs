using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    // Classe Passageiro
    public class Passageiro
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        private List<Voo> voos = new List<Voo>();

        public Passageiro() { }

        public Passageiro(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void AdicionarVoo(Voo voo, Aeroporto aeroporto)
        {
            if (voo != null && !voos.Contains(voo))
            {
                voos.Add(voo);
            }
        }

        public List<Voo> ObterVoos()
        {
            return new List<Voo>(voos);
        }
    }


    public class Voo
    {
        public string Numero { get; set; }
        public string Destino { get; set; }
        public DateTime Data { get; set; }

        public Voo() { }

        public Voo(string numero, string destino, DateTime data)
        {
            Numero = numero;
            Destino = destino;
            Data = data;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Data: {Data:dd/MM/yyyy}");
        }
    }


    public class Aeroporto
    {
        private List<Voo> voos = new List<Voo>();

        public void AdicionarVoo(Voo voo)
        {
            if (voo != null && !voos.Any(v => v.Numero == voo.Numero))
            {
                voos.Add(voo);
            }
        }

        public List<Voo> ObterVoos()
        {
            return new List<Voo>(voos);
        }

        public Voo BuscarVooPorNumero(string numero)
        {
            return voos.FirstOrDefault(v => v.Numero == numero);
        }
    }

}
