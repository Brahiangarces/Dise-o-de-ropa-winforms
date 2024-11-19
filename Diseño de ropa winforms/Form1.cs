using Diseño_de_ropa_winforms.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Diseño_de_ropa_winforms
{
    public partial class Form1 : Form
    {
        private controlarusuario controldelosusuarios;
        private controladordeprendas controlprendas;
        private Usuario usuarioActual;
        public Form1()
        {

            controldelosusuarios = new controlarusuario();
            controlprendas = new controladordeprendas();

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;
            if (controldelosusuarios.RegistrarUsuario(correo, contraseña))
            {
                MessageBox.Show("Usuario registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("El usuario ya existe.");
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;
            usuarioActual = controldelosusuarios.IniciarSesion(correo, contraseña);
            if (usuarioActual != null)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }

        }

        private void btnDiseñarPrenda_Click(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                string tipo = cbTpPrenda.Text;
                string color = cbColor.Text;
                string tejido = cbTejido.Text;
                string detalles = txtDetalles.Text;
                controlprendas.DiseñarPrenda(usuarioActual, tipo, color, tejido, detalles);
                MessageBox.Show("Prenda diseñada exitosamente.");
            }
            else
            {
                MessageBox.Show("Debe iniciar sesión primero.");
            }
        }
        private void ActualizarImagen()
        {
            string colorSeleccionado = cbColor.SelectedItem?.ToString();
            string tipoPrendaSeleccionado = cbTpPrenda.SelectedItem?.ToString();

            if (colorSeleccionado == null || tipoPrendaSeleccionado == null)
            {
                MessageBox.Show("Por favor rellenar los campos anteriores.");
                return;
            }

            if (tipoPrendaSeleccionado == "Camisa")
            {
                switch (colorSeleccionado)
                {
                    case "Azul":
                        pbFoto.Image = Properties.Resources.camisaazul;
                        break;
                    case "Rojo":
                        pbFoto.Image = Properties.Resources.camisarojaa;
                        break;
                    case "Blanco":
                        pbFoto.Image = Properties.Resources.camisetablanca;
                        break;
                }
            }
            else if (tipoPrendaSeleccionado == "Chaqueta")
            {
                switch (colorSeleccionado)
                {
                    case "Azul":
                        pbFoto.Image = Properties.Resources.chaquetaazulll;
                        break;
                    case "Rojo":
                        pbFoto.Image = Properties.Resources.chaquetaroja;
                        break;
                    case "Blanco":
                        pbFoto.Image = Properties.Resources.chaquetablancaaaa;
                        break;
                }
            }
            else if (tipoPrendaSeleccionado == "Pantalon")
            {
                switch (colorSeleccionado)
                {
                    case "Azul":
                        pbFoto.Image = Properties.Resources.pantalonazul;
                        break;
                    case "Rojo":
                        pbFoto.Image = Properties.Resources.pantalonrojo;
                        break;
                    case "Blanco":
                        pbFoto.Image = Properties.Resources.pantalonblanco;
                        break;
                }
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            ActualizarImagen();

        }

        private void cbTalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void cbTpPrenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbTejido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDetalles_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
 
