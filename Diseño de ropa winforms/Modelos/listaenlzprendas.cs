using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_de_ropa_winforms.Modelos
{
    public class listaenlzprendas
    {
        private Nodo<Prenda> cabeza;

        public listaenlzprendas()
        {
            cabeza = null;
        }

        public void AgregarPrenda(Prenda prenda)
        {
            if (cabeza == null)
            {
                cabeza = new Nodo<Prenda>(prenda);
            }
            else
            {
                AgregarPrendaRec(cabeza, prenda);
            }
        }

        private void AgregarPrendaRec(Nodo<Prenda> nodoActual, Prenda prenda)
        {
            if (nodoActual.siguiente == null)
            {
                nodoActual.siguiente = new Nodo<Prenda>(prenda);
            }
            else
            {
                AgregarPrendaRec(nodoActual.siguiente, prenda);
            }
        }

        public List<Prenda> ObtenerPrendas()
        {
            List<Prenda> prendas = new List<Prenda>();
            ObtenerPrendasRec(cabeza, prendas);
            return prendas;
        }

        private void ObtenerPrendasRec(Nodo<Prenda> nodoActual, List<Prenda> prendas)
        {
            if (nodoActual != null)
            {
                prendas.Add(nodoActual.valor);
                ObtenerPrendasRec(nodoActual.siguiente, prendas);
            }
        }
    }
}
