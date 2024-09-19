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
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        private List<Voo> voos;

        public Passageiro(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            voos = new List<Voo>();
        }

        public void AdicionarVoo(Voo voo, Aeroporto aeroporto)
        {
            if (voo != null && !voos.Contains(voo))
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
            else
            {
                Console.WriteLine("Voo não encontrado.");
            }
        }

        public List<Voo> ObterVoos()
        {
            return voos;
        }
    }


    public class Voo
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


    public class Aeroporto
    {
        private List<Voo> voos;

        public Aeroporto()
        {
            voos = new List<Voo>();
        }

        public void AdicionarVoo(Voo voo)
        {
            voos.Add(voo);
        }

        public void RemoverVoo(int idVoo)
        {
            var voo = voos.FirstOrDefault(v => v.Id == idVoo);
            if (voo != null)
            {
                voos.Remove(voo);
            }
            else
            {
                Console.WriteLine("Voo não encontrado.");
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
