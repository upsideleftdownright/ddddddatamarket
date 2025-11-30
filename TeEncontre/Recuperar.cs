using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeEncontre
{
    public partial class Recuperar : Form
    {
        public Recuperar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                labelMessage.Text = "Ingrese el correo electrónico";
                return;
            }
            else
            {
                MessageBox.Show("Se envió el codigo al correo electrónico", "Código enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                NuevaContrasenia nuevaContrasenia = new();
                nuevaContrasenia.Show();
            }
        }
    }
}
