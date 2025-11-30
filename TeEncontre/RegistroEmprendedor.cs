using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeEncontre;

namespace TeEncontre

{
    public partial class RegistroEmprendedor : Form
    {
        string fullPath = @"..\..\..\UsuariosEmprendedor.xml";
        DataSet UsuariosEmprendedor = new DataSet();
        public RegistroEmprendedor()
        {
            InitializeComponent();
        }
        public struct UsuarioEmprendedor
        {
            public string Nombres;
            public string Negocio;
            public string Cedula;
            public string CorreoElectronico;
            public string Contrasena;
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtBsname.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text) ||
                    string.IsNullOrEmpty(txtPassword2.Text) ||
                    string.IsNullOrEmpty(txtId.Text))

            {
                labelMessage.Text = "Los campos (*) son obligatorios";
                return;
            }
            else
            {
                if (txtId.Text.Length < 8)
                {
                    labelMessage.Text = "Numero de identificación no válido.";
                    txtId.Focus();
                    return;
                }
                if (txtName.Text.Length < 3 || txtBsname.Text.Length < 3)
                {
                    labelMessage.Text = "Nombre/Negocio debe tener mas de 3 caracteres.";
                    txtName.Focus();
                    return;
                }

                if (string.Equals(txtPassword.Text, txtPassword2.Text) == false)
                {
                    labelMessage.Text = "Las contraseñas no coinciden";
                    txtPassword.Focus();
                    txtPassword.Focus();
                    return;
                }

                if (txtEmail.Text.Length < 10)
                {
                    labelMessage.Text = "Ingresar un correo electrónico válido.";
                    txtEmail.Focus();
                    return;
                }

                else
                {
                    UsuarioEmprendedor nuevoEmprendedor = new UsuarioEmprendedor
                    {
                        Nombres = txtName.Text,
                        Negocio = txtBsname.Text,
                        CorreoElectronico = txtEmail.Text,
                        Cedula = txtId.Text,
                        Contrasena = txtPassword.Text
                    };

                    DataTable dtNegocios = new DataTable("Emprendedor");

                    try
                    {
                        if (File.Exists(fullPath))
                        {
                            UsuariosEmprendedor = new DataSet();
                            UsuariosEmprendedor.ReadXml(fullPath);

                            dtNegocios = UsuariosEmprendedor.Tables["Emprendedor"];
                        }
                        else
                        {
                            UsuariosEmprendedor = new DataSet("NegociosTencontre");

                            dtNegocios.Columns.Add("Nombres", typeof(string));
                            dtNegocios.Columns.Add("Negocio", typeof(string));
                            dtNegocios.Columns.Add("CorreoElectronico", typeof(string));
                            dtNegocios.Columns.Add("Cedula", typeof(string));
                            dtNegocios.Columns.Add("Contrasena", typeof(string));
                            UsuariosEmprendedor.Tables.Add(dtNegocios);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al intentar cargar/leer XML: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataRow nuevaFila = dtNegocios.NewRow();
                    nuevaFila["Nombres"] = nuevoEmprendedor.Nombres;
                    nuevaFila["Negocio"] = nuevoEmprendedor.Negocio;
                    nuevaFila["CorreoElectronico"] = nuevoEmprendedor.CorreoElectronico;
                    nuevaFila["Cedula"] = nuevoEmprendedor.Cedula;
                    nuevaFila["Contrasena"] = nuevoEmprendedor.Contrasena;
                    dtNegocios.Rows.Add(nuevaFila);

                    try
                    {
                        UsuariosEmprendedor.WriteXml(fullPath, XmlWriteMode.WriteSchema);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar XML: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Registro exitoso. ¡Bienvenido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioSesion inicioSesion = new();
                    inicioSesion.Show();
                    this.Hide();
                }

            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Inicio form1 = new();
            form1.Show();
            this.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistroUsuario registroUsuario = new();
            registroUsuario.Show();
        }

        private void RegistroEmprendedor_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
