namespace TeEncontre
{
    partial class Recuperar
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            button1 = new Button();
            labelMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.Image = Properties.Resources.logo_app;
            pictureBox1.Location = new Point(315, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 178);
            label2.Name = "label2";
            label2.Size = new Size(352, 30);
            label2.TabIndex = 2;
            label2.Text = "RECUPERACIÓN DE CONTRASEÑA";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 217);
            label3.Name = "label3";
            label3.Size = new Size(563, 95);
            label3.TabIndex = 3;
            label3.Text = "Al ingresar tu correo electrónico, te enviaremos un código de \r\nrecuperación para que puedas cambiar tu clave,\r\nno compartas el código con nadie.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(267, 324);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 4;
            label4.Text = "Correo electrónico";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 352);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@example.com";
            txtEmail.Size = new Size(385, 23);
            txtEmail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(401, 429);
            button1.Name = "button1";
            button1.Size = new Size(117, 41);
            button1.TabIndex = 6;
            button1.Text = "Enviar Código";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // labelMessage
            // 
            labelMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelMessage.Location = new Point(335, 393);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(261, 23);
            labelMessage.TabIndex = 23;
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Recuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(901, 529);
            Controls.Add(labelMessage);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Recuperar";
            Text = "Recuperar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Button button1;
        private Label labelMessage;
    }
}