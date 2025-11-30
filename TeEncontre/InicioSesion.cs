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
    public partial class InicioSesion : Form
    {
        private DataSet dsUsuarios = new DataSet();
        string fullPath = @"..\..\..\UsuariosClientes.xml";
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            if (File.Exists(fullPath))
            {
                dsUsuarios.ReadXml(fullPath);
            }
            else
            {
                MessageBox.Show("Base de datos aun no creada.");
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario RegistrarUsuario = new();
            this.Hide();
            RegistrarUsuario.Show();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar RecuperarPass = new();
            RecuperarPass.Show();
            this.Hide();
        }

        private void BtnLogIn2_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblMessage2.Text = "";

            string user = txtUser.Text.Trim();
            string pass = textPass.Text.Trim();
            bool credencialesValidas = false;


            if (string.IsNullOrEmpty(user))
            {
                lblMessage.Text = "El usuario no puede estar vacío";
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                lblMessage2.Text = "La contraseña no puede estar vacía";
                textPass.Focus();
                return;
            }

            //usuario de prueba
            if (dsUsuarios.Tables.Contains("Cliente"))
            {
                DataTable dtClientes = dsUsuarios.Tables["Cliente"];

                foreach (DataRow fila in dtClientes.Rows)
                {
                    string usuarioGuardado = fila["Usuario"].ToString();
                    string contrasenaGuardada = fila["Contrasena"].ToString();

                    if (user == usuarioGuardado && pass == contrasenaGuardada)
                    {
                        credencialesValidas = true;
                        break;
                    }
                }
            }
            if (credencialesValidas == true)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TiendaCliente Form1 = new();
                Form1.Show();
                this.Hide();
            }
            else
            {
                lblMessage2.Text = "Usuario o contraseña incorrectos";
            }
        }
    }
}
