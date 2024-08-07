using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class OperadoresLogicos
    {

        // Metodo que demonstra o operador E logico (&&)
        public static bool ELogico(bool a, bool b)
        {
            return a && b;
        }

        // Metodo que demonstra o operador OU logico (||)
        public static bool OULogico(bool a, bool b)
        {
            return a || b;
        }

        // Metodo que demonstra o operador NEGAÇÃO (!)
        public static bool Negacao(bool a)
        {
            return !a;
        }

        // Metodo que demonstra o operador XOR ou OU EXCLUSIVO (^)
        public static bool OUExclusivo(bool a, bool b)
        {
            return a ^ b;
        }

        



    }
}
