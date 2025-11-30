using System;
using System.Net.Mail;
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
    public partial class RegistroUsuario : Form
    {
        string fullPath = @"..\..\..\UsuariosClientes.xml";
        DataSet Usuarios;

        public RegistroUsuario()
        {
            InitializeComponent();
            Usuarios = new DataSet("UsuariosTencontre");

            if (File.Exists(fullPath))
            {
                try
                {
                    Usuarios.ReadXml(fullPath, XmlReadMode.ReadSchema);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar XML: " + ex.Message, "Se creará una nueva estructura.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CrearEstructuraInicial(Usuarios);
                }
            }
            else
            {
                CrearEstructuraInicial(Usuarios);
            }
        }

        private void CrearEstructuraInicial(DataSet ds)
        {
            DataTable dtClientes = new DataTable("Cliente");
            dtClientes.Columns.Add("Nombres", typeof(string));
            dtClientes.Columns.Add("Usuario", typeof(string));
            dtClientes.Columns.Add("CorreoElectronico", typeof(string));
            dtClientes.Columns.Add("Contrasena", typeof(string));
            ds.Tables.Add(dtClientes);
        }


        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
        }

        public struct UsuarioCliente
        {
            public string Nombres;
            public string Usuario;
            public string CorreoElectronico;
            public string Contrasena;
        }

        private void BtnLogIn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxName.Text) || (string.IsNullOrEmpty(txtBoxEmail.Text))
                || (string.IsNullOrEmpty(txtBoxPass.Text)) || (string.IsNullOrEmpty(txtBoxPass2.Text))
                || string.IsNullOrEmpty(textBoxUser.Text))
            {
                lblMessage.Text = "Los campos (*) son obligatorios";
                txtBoxName.Focus();
                return;
            }
            else
            {
                if (txtBoxName.Text.Length < 3 || textBoxUser.Text.Length < 3)
                {
                    lblMessage.Text = "Usuario/Nombre debe tener mas de 3 caracteres.";
                    txtBoxEmail.Focus();
                    return;
                }

                if (txtBoxPass.Text.Length < 8)
                {
                    lblMessage.Text = "La contraseña debe de contener al menos 8 dígitos.";
                    txtBoxPass.Focus();
                    return;
                }

                if (txtBoxEmail.Text.Length < 10)
                {
                    lblMessage.Text = "Ingresar un correo electrónico válido.";
                    txtBoxEmail.Focus();
                    return;
                }

                if (string.Equals(txtBoxPass.Text, txtBoxPass2.Text) == false)
                {
                    lblMessage.Text = "Las contraseñas no coinciden";
                    txtBoxPass.Focus();
                    txtBoxPass2.Focus();
                    return;
                }
                else
                {
                    DataTable dtClientes;

                    if (Usuarios.Tables.Contains("Cliente"))
                    {
                        dtClientes = Usuarios.Tables["Cliente"];
                    }
                    else
                    {
                        CrearEstructuraInicial(Usuarios);
                        dtClientes = Usuarios.Tables["Cliente"];
                    }

                    UsuarioCliente nuevoCliente = new UsuarioCliente
                    {
                        Nombres = txtBoxName.Text,
                        Usuario = textBoxUser.Text,
                        CorreoElectronico = txtBoxEmail.Text,
                        Contrasena = txtBoxPass.Text
                    };

                    DataRow nuevaFila = dtClientes.NewRow();
                    nuevaFila["Nombres"] = nuevoCliente.Nombres;
                    nuevaFila["Usuario"] = nuevoCliente.Usuario;
                    nuevaFila["CorreoElectronico"] = nuevoCliente.CorreoElectronico;
                    nuevaFila["Contrasena"] = nuevoCliente.Contrasena;
                    dtClientes.Rows.Add(nuevaFila); 
                    try
                    {
                        Usuarios.WriteXml(fullPath, XmlWriteMode.WriteSchema);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar XML: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Usuario registrado con éxito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioSesion LogIn = new();
                    this.Hide();
                    LogIn.Show();
                }
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroEmprendedor RegistrarEmprendedor = new();
            this.Hide();
            RegistrarEmprendedor.Show();
        }

        private void lnkLblUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistroEmprendedor registroEmprendedor = new();
            registroEmprendedor.Show();

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
