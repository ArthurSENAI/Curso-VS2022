using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    // Classe Passageiro
    class Passageiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        private List<Voo> voos = new List<Voo>();

        public Passageiro(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
        }

        public void AdicionarVoo(Voo voo, Aeroporto aeroporto)
        {
            if (!voos.Contains(voo))
            {
                voos.Add(voo);
            }
        }

        public List<Voo> ObterVoos()
        {
            return voos;
        }
    }

    class Voo
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }

        public Voo(int id, string numero, string origem, string destino)
        {
            Id = id;
            Numero = numero;
            Origem = origem;
            Destino = destino;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {Id} - Número: {Numero} - Origem: {Origem} - Destino: {Destino}");
        }
    }

    class Aeroporto
    {
        private List<Voo> voos = new List<Voo>();

        public void AdicionarVoo(Voo voo)
        {
            if (!voos.Any(v => v.Id == voo.Id))
            {
                voos.Add(voo);
            }
        }

        public void RemoverVoo(int idVoo)
        {
            var voo = voos.FirstOrDefault(v => v.Id == idVoo);
            if (voo != null)
            {
                voos.Remove(voo);
            }
        }

        public Voo BuscarVooPorId(int id)
        {
            return voos.FirstOrDefault(v => v.Id == id);
        }

        public List<Voo> ObterVoos()
        {
            return voos;
        }
    }


}
