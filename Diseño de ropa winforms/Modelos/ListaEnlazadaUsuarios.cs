using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_de_ropa_winforms.Modelos
{
    public class ListaEnlazadaUsuarios
    {
        private Nodo<Usuario> cabeza;

        public ListaEnlazadaUsuarios()
        {
            cabeza = null;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (cabeza == null)
            {
                cabeza = new Nodo<Usuario>(usuario);
            }
            else
            {
                AgregarUsuarioRec(cabeza, usuario);
            }
        }

        private void AgregarUsuarioRec(Nodo<Usuario> nodoActual, Usuario user)
        {
            if (nodoActual.siguiente == null)
            {
                nodoActual.siguiente = new Nodo<Usuario>(user);
            }
            else
            {
                AgregarUsuarioRec(nodoActual.siguiente, user);
            }
        }

        public Usuario BuscarUsuario(string correo)
        {
            return BuscarUsuarioRec(cabeza, correo);
        }

        private Usuario BuscarUsuarioRec(Nodo<Usuario> nodoActual, string correo)
        {
            if (nodoActual == null)
                return null;
            if (nodoActual.valor.correo == correo)
                return nodoActual.valor;

            return BuscarUsuarioRec(nodoActual.siguiente, correo);
        }
    }

}
