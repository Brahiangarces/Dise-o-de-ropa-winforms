using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_de_ropa_winforms.Modelos
{
    public class Prenda
    {
        public string tipo { get; set; }
        public string color { get; set; }
        public string tejido { get; set; }
        public string detalles { get; set; }
        public string talla { get; set; }

        public Prenda(string tipo, string color, string tejido, string detalles)
        {
            this.tipo = tipo;
            this.color = color;
            this.tejido = tejido;
            this.detalles = detalles;
            this.talla = "Estandar";
        }
    }
}
