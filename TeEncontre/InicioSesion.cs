using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeEncontre
{
    public partial class InicioSesion : Form
    {
        private DataSet dsClientes = new DataSet();
        private DataSet dsEmprendedores = new DataSet();
        string pathClientes = @"..\..\..\UsuariosClientes.xml";
        string pathEmprendedores = @"..\..\..\UsuariosEmprendedor.xml";
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathClientes))
            {
                dsClientes.ReadXml(pathClientes, XmlReadMode.ReadSchema);
            }
            if (File.Exists(pathEmprendedores))
            {
                dsEmprendedores.ReadXml(pathEmprendedores, XmlReadMode.ReadSchema);
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
            string tipoUsuario = "";


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

            if (dsClientes.Tables.Contains("Cliente"))
            {
                DataTable dtClientes = dsClientes.Tables["Cliente"];

                foreach (DataRow fila in dtClientes.Rows)
                {
                    string usuarioGuardado = fila["Usuario"].ToString();
                    string contrasenaGuardada = fila["Contrasena"].ToString();

                    if (user == usuarioGuardado && pass == contrasenaGuardada)
                    {
                        credencialesValidas = true;
                        tipoUsuario = "Cliente";
                        break;
                    }
                }
            }

            if (!credencialesValidas && dsEmprendedores.Tables.Contains("Emprendedor"))
            {
                DataTable dtEmprendedores = dsEmprendedores.Tables["Emprendedor"];

                foreach (DataRow fila in dtEmprendedores.Rows)
                {
                    string usuarioGuardado = fila["Negocio"].ToString();
                    string contrasenaGuardada = fila["Contrasena"].ToString();

                    if (user == usuarioGuardado && pass == contrasenaGuardada)
                    {
                        credencialesValidas = true;
                        tipoUsuario = "Emprendedor";
                        break;
                    }
                }
            }

            if (credencialesValidas)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(tipoUsuario == "Cliente")
                {
                    TiendaCliente Form1 = new();
                    Form1.Show();
                    this.Hide();
                }

                else if (tipoUsuario == "Emprendedor")
                {
                    TiendaEmprendedor Form = new();
                    Form.Show();
                    this.Hide();
                }
            }
            else
            {
                lblMessage2.Text = "Usuario o contraseña incorrectos";
            }
        }
    }
}
