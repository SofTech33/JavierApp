using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase Usuario
            Usuario usuario = new Usuario(txtUsuario.Text, txtContrasena.Text, 0);

            // Verificar credenciales
            if (usuario.VerificarUsuario(txtUsuario.Text, txtContrasena.Text))
            {
                MessageBox.Show("Login correcto");
            }
            else
            {
                MessageBox.Show("Login incorrecto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
