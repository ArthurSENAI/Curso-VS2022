using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class ExplicacaoStructs
    {
        // Definição de uma struct
        public struct Ponto2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Ponto2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void ExibirPonto()
            {
                Console.WriteLine($"Ponto: ({X}, {Y})");
            }
        }

        // Definição de uma classe
        public class Ponto3D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public Ponto3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public void ExibirPonto()
            {
                Console.WriteLine($"Ponto: ({X}, {Y}, {Z})");
            }
        }

        public void DemonstrarDiferenca()
        {
            // Instanciando e usando uma struct
            Ponto2D ponto2D = new Ponto2D(10, 20);
            ponto2D.ExibirPonto(); // Saída: Ponto: (10, 20)

            // Instanciando e usando uma classe
            Ponto3D ponto3D = new Ponto3D(10, 20, 30);
            ponto3D.ExibirPonto(); // Saída: Ponto: (10, 20, 30)

            // Demonstrando a diferença de comportamento entre struct e classe
            Ponto2D ponto2DCopia = ponto2D; // Cópia por valor
            ponto2DCopia.X = 100;
            Console.WriteLine($"Ponto2D Original: ({ponto2D.X}, {ponto2D.Y})"); // Saída: (10, 20)
            Console.WriteLine($"Ponto2D Copiado: ({ponto2DCopia.X}, {ponto2DCopia.Y})"); // Saída: (100, 20)

            Ponto3D ponto3DCopia = ponto3D; // Cópia por referência
            ponto3DCopia.X = 100;
            Console.WriteLine($"Ponto3D Original: ({ponto3D.X}, {ponto3D.Y}, {ponto3D.Z})"); // Saída: (100, 20, 30)
            Console.WriteLine($"Ponto3D Copiado: ({ponto3DCopia.X}, {ponto3DCopia.Y}, {ponto3DCopia.Z})"); // Saída: (100, 20, 30)
        }
    }
}
