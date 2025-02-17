﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    /*
     Tipo de Valor vs. Tipo de Referência:
    class: É um tipo de referência. Quando você cria uma instância de uma classe, você está criando um objeto que é armazenado no heap. Variáveis de classe armazenam referências ao objeto, não o próprio objeto.
    struct: É um tipo de valor. Quando você cria uma instância de uma struct, ela é armazenada na stack (ou no heap, se for um campo de uma classe) e as variáveis de struct contêm diretamente o valor.

    Herança:
    class: Suporta herança. Você pode criar uma classe base e derivar outras classes dela.
    struct: Não suporta herança. Estruturas não podem ser base para outras structs ou classes e não podem derivar de outras structs ou classes (exceto para System.ValueType).

    Construtores e Destrutores:
    class: Pode ter construtores personalizados e destrutores (finalizadores).
    struct: Tem um construtor padrão implícito (que inicializa todos os campos com valores padrão) e você pode definir construtores parametrizados, mas não pode ter um destruidor.

    Inicialização e Cópia:
    class: Quando você copia uma variável de classe, você copia a referência, não o objeto em si. Portanto, alterações em uma instância afetam todas as variáveis que referenciam essa instância.
    struct: Quando você copia uma variável de struct, você copia o valor inteiro. Isso significa que alterações em uma cópia não afetam a instância original.

    Nullabilidade:
    class: Pode ser null. Você pode ter uma referência de classe que não aponta para nenhum objeto.
    struct: Não pode ser null (exceto quando usado como Nullable<T>). Eles sempre contêm um valor.

    Performance e Tamanho:
    class: Usualmente usado quando você precisa de objetos maiores e mais complexos, especialmente quando a herança e polimorfismo são necessários.
    struct: Usado para objetos pequenos e imutáveis que são frequentemente criados e destruídos, como vetores e coordenadas. Estruturas podem ter desempenho melhor para esses casos, 
    mas usar structs grandes pode levar a uma maior sobrecarga de cópias.

    Padronização:
    class: Tipicamente usado para modelar entidades que possuem comportamento e estado mais complexo.
    struct: Geralmente usado para dados simples e pequenas quantidades de informações que não precisam de herança ou polimorfismo.

     */
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
