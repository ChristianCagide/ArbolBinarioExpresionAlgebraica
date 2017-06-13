using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Nodo
    {
        public char dato { get; set; }
        public Nodo hIzq { get; set; }
        public Nodo hDer { get; set; }
        public Nodo siguiente { get; set; }
        public Nodo anterior { get; set; }

        public Nodo(char d)
        {
            dato = d;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
