namespace TeEncontre
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textPass = new TextBox();
            btnLogIn2 = new Button();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label5 = new Label();
            lblMessage = new Label();
            lblMessage2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(304, 286);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(292, 23);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 255);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 336);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // textPass
            // 
            textPass.BackColor = SystemColors.Window;
            textPass.Location = new Point(304, 365);
            textPass.Name = "textPass";
            textPass.PasswordChar = '*';
            textPass.Size = new Size(292, 23);
            textPass.TabIndex = 3;
            textPass.UseSystemPasswordChar = true;
            // 
            // btnLogIn2
            // 
            btnLogIn2.BackColor = Color.Linen;
            btnLogIn2.FlatAppearance.BorderSize = 0;
            btnLogIn2.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnLogIn2.FlatStyle = FlatStyle.Flat;
            btnLogIn2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn2.Location = new Point(407, 463);
            btnLogIn2.Name = "btnLogIn2";
            btnLogIn2.Size = new Size(105, 38);
            btnLogIn2.TabIndex = 5;
            btnLogIn2.Text = "Iniciar Sesión";
            btnLogIn2.UseVisualStyleBackColor = false;
            btnLogIn2.Click += BtnLogIn2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(281, 209);
            label4.Name = "label4";
            label4.Size = new Size(315, 34);
            label4.TabIndex = 6;
            label4.Text = "¿No tienes una cuenta?";
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            linkLabel2.Location = new Point(516, 209);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 34);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrate aquí";
            linkLabel2.LinkClicked += LinkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            linkLabel3.Location = new Point(516, 420);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(138, 33);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Recupérala aquí.";
            linkLabel3.LinkClicked += LinkLabel3_LinkClicked;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(281, 419);
            label5.Name = "label5";
            label5.Size = new Size(243, 33);
            label5.TabIndex = 8;
            label5.Text = "¿Olvidaste tu contraseña?";
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(304, 310);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(292, 29);
            lblMessage.TabIndex = 10;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage2
            // 
            lblMessage2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMessage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage2.ForeColor = Color.Red;
            lblMessage2.Location = new Point(304, 391);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new Size(292, 29);
            lblMessage2.TabIndex = 11;
            lblMessage2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(930, 529);
            Controls.Add(lblMessage2);
            Controls.Add(lblMessage);
            Controls.Add(linkLabel3);
            Controls.Add(label5);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(btnLogIn2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textPass);
            Name = "InicioSesion";
            Text = "InicioSesion";
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private TextBox textPass;
        private Button btnLogIn2;
        private Label lblMessage2;
        private Label label4;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label5;
        private Label lblMessage;
    }
}