namespace TeEncontre
{
    partial class NuevaContrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaContrasenia));
            linkLabel3 = new LinkLabel();
            labelQues = new Label();
            btnSave = new Button();
            labelCod = new Label();
            txtCod = new TextBox();
            pictureBox1 = new PictureBox();
            labelPass = new Label();
            txtPass = new TextBox();
            labelMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel3
            // 
            linkLabel3.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.Location = new Point(446, 356);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(121, 33);
            linkLabel3.TabIndex = 21;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Reenviar aquí.";
            linkLabel3.LinkClicked += LinkLabel3_LinkClicked;
            // 
            // labelQues
            // 
            labelQues.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQues.Location = new Point(254, 356);
            labelQues.Name = "labelQues";
            labelQues.Size = new Size(200, 33);
            labelQues.TabIndex = 20;
            labelQues.Text = "¿No recibiste el código?";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Linen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(362, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 38);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // labelCod
            // 
            labelCod.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCod.Location = new Point(264, 173);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(74, 33);
            labelCod.TabIndex = 14;
            labelCod.Text = "Código:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(264, 209);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(292, 23);
            txtCod.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(264, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // labelPass
            // 
            labelPass.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPass.Location = new Point(264, 246);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(208, 28);
            labelPass.TabIndex = 16;
            labelPass.Text = "Nueva contraseña:";
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.Window;
            txtPass.Location = new Point(264, 277);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(292, 23);
            txtPass.TabIndex = 15;
            txtPass.UseSystemPasswordChar = true;
            // 
            // labelMessage
            // 
            labelMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelMessage.Location = new Point(278, 319);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(261, 23);
            labelMessage.TabIndex = 22;
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NuevaContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(827, 475);
            Controls.Add(labelMessage);
            Controls.Add(linkLabel3);
            Controls.Add(labelQues);
            Controls.Add(btnSave);
            Controls.Add(labelCod);
            Controls.Add(txtCod);
            Controls.Add(pictureBox1);
            Controls.Add(labelPass);
            Controls.Add(txtPass);
            Name = "NuevaContrasenia";
            Text = "NuevaContrasenia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel3;
        private Label labelQues;
        private Button btnSave;
        private Label labelCod;
        private TextBox txtCod;
        private PictureBox pictureBox1;
        private Label labelPass;
        private TextBox txtPass;
        private Label labelMessage;
    }
}