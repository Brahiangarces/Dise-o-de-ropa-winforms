using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_de_ropa_winforms.Modelos
{
    //clase usuario
    public class controlarusuario
    {
        private ListaEnlazadaUsuarios usuarios;

        public controlarusuario()
        {
            usuarios = new ListaEnlazadaUsuarios();
        }

        public bool RegistrarUsuario(string correo, string contraseña)
        {
            if (usuarios.BuscarUsuario(correo) == null)
            {
                Usuario nuevo = new Usuario(correo, contraseña);
                usuarios.AgregarUsuario(nuevo);
                return true;
            }
            return false;
        }

        public Usuario IniciarSesion(string correo, string contraseña)
        {
            Usuario user = usuarios.BuscarUsuario(correo);
            if (user != null && user.contraseña == contraseña)
            {
                return user;
            }
            return null;
        }
    }
}
