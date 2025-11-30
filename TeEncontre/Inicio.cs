namespace TeEncontre
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            InicioSesion logIn = new();
            this.Hide();
            logIn.Show();
        }

        public void BtnReg_Click(object sender, EventArgs e)
        {
            RegistroUsuario RegistrarCliente = new();
            this.Hide();
            RegistrarCliente.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
