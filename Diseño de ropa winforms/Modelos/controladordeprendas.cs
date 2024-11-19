using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Diseño_de_ropa_winforms.Modelos
{
    public class controladordeprendas
    {
        public void DiseñarPrenda(Usuario usuario, string tipo, string color, string tejido, string detalles)
        {
            Prenda nueva = new Prenda(tipo, color, tejido, detalles);
            usuario.prendasdiseñadas.AgregarPrenda(nueva);
        }

        public void AjustarTalla(Usuario usuario, Prenda prenda, string talla)
        {
            prenda.talla = talla;
        }


        public void VistaPrevia(Prenda prenda)
        {
            WriteLine($"Prenda preview: {prenda.tipo} - {prenda.color} - {prenda.talla}");
        }


        public void CompartirDiseño(Usuario usuario, Prenda prenda)
        {
            WriteLine($"Diseño de {prenda.tipo} compartido.");
        }
    }
}
