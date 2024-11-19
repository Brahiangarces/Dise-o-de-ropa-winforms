using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_de_ropa_winforms.Modelos
{
    //modelos
    public class NodoArbol<T>
    {
        public T Valor { get; set; }
        public NodoArbol<T> Izquierda { get; set; }
        public NodoArbol<T> Derecha { get; set; }

        public NodoArbol(T valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }

    public class ArbolBinario<T> where T : IComparable
    {
        private NodoArbol<T> raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public void Agregar(T valor)
        {
            if (raiz == null)
            {
                raiz = new NodoArbol<T>(valor);
            }
            else
            {
                AgregarRecursivo(raiz, valor);
            }
        }

        private void AgregarRecursivo(NodoArbol<T> nodoActual, T valor)
        {
            if (valor.CompareTo(nodoActual.Valor) < 0)
            {
                if (nodoActual.Izquierda == null)
                {
                    nodoActual.Izquierda = new NodoArbol<T>(valor);
                }
                else
                {
                    AgregarRecursivo(nodoActual.Izquierda, valor);
                }
            }
            else
            {
                if (nodoActual.Derecha == null)
                {
                    nodoActual.Derecha = new NodoArbol<T>(valor);
                }
                else
                {
                    AgregarRecursivo(nodoActual.Derecha, valor);
                }
            }
        }

        public List<T> ObtenerValores()
        {
            List<T> valores = new List<T>();
            ObtenerValoresRecursivo(raiz, valores);
            return valores;
        }

        private void ObtenerValoresRecursivo(NodoArbol<T> nodoActual, List<T> valores)
        {
            if (nodoActual != null)
            {
                ObtenerValoresRecursivo(nodoActual.Izquierda, valores);
                valores.Add(nodoActual.Valor);
                ObtenerValoresRecursivo(nodoActual.Derecha, valores);
            }
        }
    }

    public class Usuario
    {
        public string correo { get; set; }
        public string contraseña { get; set; }
        public listaenlzprendas prendasdiseñadas { get; set; }

        public Usuario(string correo, string contraseña)
        {
            this.correo = correo;
            this.contraseña = contraseña;
            prendasdiseñadas = new listaenlzprendas();
        }
    }
}
