using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_de_ropa_winforms.Modelos
{//nodo
    public class Nodo<T>
    {
        public T valor { get; set; }
        public Nodo<T> siguiente { get; set; }

        public Nodo(T val)
        {
            valor = val;
            siguiente = null;
        }
    }
}
