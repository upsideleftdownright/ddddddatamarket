namespace TeEncontre
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox1 = new PictureBox();
            btnLogIn = new Button();
            btnReg = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = SystemColors.Desktop;
            btnLogIn.Location = new Point(594, 24);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(126, 38);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Iniciar Sesión";
            btnLogIn.UseMnemonic = false;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += Button1_Click;
            // 
            // btnReg
            // 
            btnReg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReg.BackColor = Color.Transparent;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = SystemColors.Desktop;
            btnReg.Location = new Point(738, 24);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(129, 38);
            btnReg.TabIndex = 1;
            btnReg.Text = "Registrarse";
            btnReg.UseMnemonic = false;
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += BtnReg_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(939, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 4;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(930, 529);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnReg);
            Controls.Add(btnLogIn);
            Controls.Add(pictureBox1);
            Name = "Inicio";
            Text = "Form1";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogIn;
        private Button btnReg;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}
