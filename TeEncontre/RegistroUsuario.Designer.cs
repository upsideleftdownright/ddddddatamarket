namespace TeEncontre
{
    partial class RegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            btnRegister = new Button();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            labelEmail = new Label();
            labelPass = new Label();
            labelPass2 = new Label();
            txtBoxPass = new TextBox();
            txtBoxName = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxPass2 = new TextBox();
            label7 = new Label();
            lnkLblUser = new LinkLabel();
            lblMessage = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxUser = new TextBox();
            labelUser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Linen;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(404, 479);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 38);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnLogIn2_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName.Location = new Point(319, 194);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 21);
            labelName.TabIndex = 8;
            labelName.Text = "Nombres:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 110);
            label3.Name = "label3";
            label3.Size = new Size(334, 30);
            label3.TabIndex = 12;
            label3.Text = "REGISTRO DE USUARIO CLIENTE";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelEmail.Location = new Point(319, 297);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(155, 21);
            labelEmail.TabIndex = 17;
            labelEmail.Text = "Correo electrónico:";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPass.Location = new Point(319, 347);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(100, 21);
            labelPass.TabIndex = 18;
            labelPass.Text = "Contraseña:";
            // 
            // labelPass2
            // 
            labelPass2.AutoSize = true;
            labelPass2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPass2.Location = new Point(319, 397);
            labelPass2.Name = "labelPass2";
            labelPass2.Size = new Size(179, 21);
            labelPass2.TabIndex = 19;
            labelPass2.Text = "Confirmar contraseña:";
            // 
            // txtBoxPass
            // 
            txtBoxPass.Location = new Point(319, 371);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(292, 23);
            txtBoxPass.TabIndex = 20;
            txtBoxPass.UseSystemPasswordChar = true;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(319, 218);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(292, 23);
            txtBoxName.TabIndex = 21;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(319, 321);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(292, 23);
            txtBoxEmail.TabIndex = 22;
            txtBoxEmail.TextChanged += txtBoxEmail_TextChanged;
            // 
            // txtBoxPass2
            // 
            txtBoxPass2.Location = new Point(319, 421);
            txtBoxPass2.Name = "txtBoxPass2";
            txtBoxPass2.Size = new Size(292, 23);
            txtBoxPass2.TabIndex = 23;
            txtBoxPass2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(277, 161);
            label7.Name = "label7";
            label7.Size = new Size(294, 21);
            label7.TabIndex = 28;
            label7.Text = "Si necesitas un usuario emprendedor,";
            // 
            // lnkLblUser
            // 
            lnkLblUser.AutoSize = true;
            lnkLblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLblUser.Location = new Point(567, 161);
            lnkLblUser.Name = "lnkLblUser";
            lnkLblUser.Size = new Size(110, 21);
            lnkLblUser.TabIndex = 29;
            lnkLblUser.TabStop = true;
            lnkLblUser.Text = "da click aquí.";
            lnkLblUser.LinkClicked += lnkLblUser_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(349, 447);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(222, 29);
            lblMessage.TabIndex = 30;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(292, 203);
            label1.Name = "label1";
            label1.Size = new Size(21, 25);
            label1.TabIndex = 31;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(292, 298);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 32;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(292, 347);
            label4.Name = "label4";
            label4.Size = new Size(21, 25);
            label4.TabIndex = 33;
            label4.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(292, 398);
            label6.Name = "label6";
            label6.Size = new Size(21, 25);
            label6.TabIndex = 34;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(292, 248);
            label5.Name = "label5";
            label5.Size = new Size(21, 25);
            label5.TabIndex = 37;
            label5.Text = "*";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(319, 271);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(292, 23);
            textBoxUser.TabIndex = 36;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUser.Location = new Point(319, 247);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(73, 21);
            labelUser.TabIndex = 35;
            labelUser.Text = "Usuario:";
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(930, 529);
            Controls.Add(label5);
            Controls.Add(textBoxUser);
            Controls.Add(labelUser);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            Controls.Add(lnkLblUser);
            Controls.Add(label7);
            Controls.Add(txtBoxPass2);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxPass);
            Controls.Add(labelPass2);
            Controls.Add(labelPass);
            Controls.Add(labelEmail);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "RegistroUsuario";
            Text = "RegistroUsuario";
            Load += RegistroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label labelName;
        private PictureBox pictureBox1;
        private Label label3;
        private Label labelEmail;
        private Label labelPass;
        private Label labelPass2;
        private TextBox txtBoxPass;
        private TextBox txtBoxName;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPass2;
        private Label label5;
        //private LinkLabel linkLabel1;
        private Label label7;
        private LinkLabel lnkLblUser;
        private Label lblMessage;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        //private TextBox textBox1;
        //private Label label8;
        private Label labelUser;
        private TextBox textBoxUser;
    }
}