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
    public partial class NuevaContrasenia : Form
    {
        public NuevaContrasenia()
        {
            InitializeComponent();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar recuperar = new();
            this.Hide();
            recuperar.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text.Trim())) {
                labelMessage.Text = "Rellene los campos solicitados";
                return;
            }
            else
            {
                MessageBox.Show("Se realizó el cambio de contraseña", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicioSesion inicioSesion = new();
                this.Hide();
                inicioSesion.Show();
            }
        }
    }
}
