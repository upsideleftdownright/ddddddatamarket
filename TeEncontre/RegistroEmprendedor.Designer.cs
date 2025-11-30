using System;
using System.Windows.Forms;

namespace TeEncontre
{
    partial class RegistroEmprendedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmprendedor));
            logotencontreimg = new PictureBox();
            SUBTITULO = new Label();
            SUBTITULO2 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtBsname = new TextBox();
            lblNombre = new Label();
            lblCedula = new Label();
            lblNombredenegocio = new Label();
            lblContraseña = new Label();
            lblCorreo = new Label();
            lblConfirmarcontraseña = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            btnRegister = new Button();
            labelMessage = new Label();
            this.txtPassword = new TextBox();
            this.txtPassword2 = new TextBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)logotencontreimg).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(365, 346);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(213, 23);
            txtPassword.TabIndex = 29;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(614, 346);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(213, 23);
            txtPassword2.TabIndex = 30;
            txtPassword2.UseSystemPasswordChar = true;
            // 
            // logotencontreimg
            // 
            logotencontreimg.Image = (Image)resources.GetObject("logotencontreimg.Image");
            logotencontreimg.Location = new Point(308, 39);
            logotencontreimg.Margin = new Padding(4, 3, 4, 3);
            logotencontreimg.Name = "logotencontreimg";
            logotencontreimg.Size = new Size(331, 114);
            logotencontreimg.SizeMode = PictureBoxSizeMode.StretchImage;
            logotencontreimg.TabIndex = 0;
            logotencontreimg.TabStop = false;
            // 
            // SUBTITULO
            // 
            SUBTITULO.AutoSize = true;
            SUBTITULO.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SUBTITULO.ForeColor = Color.Black;
            SUBTITULO.Location = new Point(284, 156);
            SUBTITULO.Margin = new Padding(4, 0, 4, 0);
            SUBTITULO.Name = "SUBTITULO";
            SUBTITULO.Size = new Size(389, 28);
            SUBTITULO.TabIndex = 1;
            SUBTITULO.Text = "REGISTRO DE USUARIO EMPRENDEDOR";
            // 
            // SUBTITULO2
            // 
            SUBTITULO2.Anchor = AnchorStyles.None;
            SUBTITULO2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SUBTITULO2.ForeColor = Color.Transparent;
            SUBTITULO2.Location = new Point(275, 195);
            SUBTITULO2.Margin = new Padding(4, 0, 4, 0);
            SUBTITULO2.Name = "SUBTITULO2";
            SUBTITULO2.Size = new Size(408, 62);
            SUBTITULO2.TabIndex = 2;
            SUBTITULO2.Text = "¡Bienvenido querido emprendedor! Para registrar tu negocio en nuestra plataforma, necesitamos que nos brindes la siguiente información.";
            SUBTITULO2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 280);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 22);
            txtName.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 349);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 20);
            txtId.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(615, 280);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 22);
            txtEmail.TabIndex = 7;
            // 
            // txtBsname
            // 
            txtBsname.Location = new Point(365, 280);
            txtBsname.Margin = new Padding(4, 3, 4, 3);
            txtBsname.Multiline = true;
            txtBsname.Name = "txtBsname";
            txtBsname.Size = new Size(213, 22);
            txtBsname.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(101, 261);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(101, 330);
            lblCedula.Margin = new Padding(4, 0, 4, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(152, 15);
            lblCedula.TabIndex = 10;
            lblCedula.Text = "Cedula de Id. / Código RUD";
            // 
            // lblNombredenegocio
            // 
            lblNombredenegocio.AutoSize = true;
            lblNombredenegocio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombredenegocio.Location = new Point(365, 261);
            lblNombredenegocio.Margin = new Padding(4, 0, 4, 0);
            lblNombredenegocio.Name = "lblNombredenegocio";
            lblNombredenegocio.Size = new Size(113, 15);
            lblNombredenegocio.TabIndex = 11;
            lblNombredenegocio.Text = "Nombre de negocio";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(365, 330);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 12;
            lblContraseña.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(611, 261);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 13;
            lblCorreo.Text = "Correo electrónico";
            // 
            // lblConfirmarcontraseña
            // 
            lblConfirmarcontraseña.AutoSize = true;
            lblConfirmarcontraseña.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarcontraseña.Location = new Point(611, 330);
            lblConfirmarcontraseña.Margin = new Padding(4, 0, 4, 0);
            lblConfirmarcontraseña.Name = "lblConfirmarcontraseña";
            lblConfirmarcontraseña.Size = new Size(118, 13);
            lblConfirmarcontraseña.TabIndex = 14;
            lblConfirmarcontraseña.Text = "Confirmar contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(77, 261);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 18;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(341, 261);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 19;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(591, 261);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 20;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(77, 325);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 21;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(341, 330);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 22;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(591, 330);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 23;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 497);
            label7.Name = "label7";
            label7.Size = new Size(164, 15);
            label7.TabIndex = 24;
            label7.Text = "Si necesitas un usuario cliente";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(509, 497);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "da click aquí";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSeaGreen;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(356, 438);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 38);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "REGISTRARSE";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // labelMessage
            // 
            labelMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelMessage.Location = new Point(369, 390);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(213, 23);
            labelMessage.TabIndex = 27;
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSeaGreen;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(481, 438);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // RegistroEmprendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(915, 532);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(labelMessage);
            Controls.Add(btnRegister);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblConfirmarcontraseña);
            Controls.Add(lblCorreo);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombredenegocio);
            Controls.Add(lblCedula);
            Controls.Add(lblNombre);
            Controls.Add(txtBsname);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(SUBTITULO2);
            Controls.Add(SUBTITULO);
            Controls.Add(logotencontreimg);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistroEmprendedor";
            Text = "Registro Emprendedor";
            Load += RegistroEmprendedor_Load;
            ((System.ComponentModel.ISupportInitialize)logotencontreimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox logotencontreimg;
        public System.Windows.Forms.Label SUBTITULO;
        private System.Windows.Forms.Label SUBTITULO2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBsname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombredenegocio;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblConfirmarcontraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel1;
        private Button btnRegister;
        private Label labelMessage;
        private Button btnCancel;
    }

}

