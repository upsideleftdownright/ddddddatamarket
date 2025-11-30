using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeEncontre
{
    public partial class TiendaCliente : Form
    {
        public TiendaCliente()
        {
            InitializeComponent();
        }


        public record Producto(string Name, string PriceText);
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            List<Producto> productos = new List<Producto>
            {
                new Producto("Arroz", $"C$ {random.Next(18, 23)}/Lb"),
                new Producto("Maiz", $"C$ {random.Next(14, 17)}/Lb"),
                new Producto("Avena", $"C$ {random.Next(18, 22)}/Lb"),
                new Producto("Frijoles", $"C$ {random.Next(25, 32)}/Lb"),
                new Producto("Azucar", $"C$ {random.Next(11, 19)}/Lb")
            };

            price.Text = productos[0].PriceText;
            priceMaiz.Text = productos[1].PriceText;
            priceAvena.Text = productos[2].PriceText;
            priceFrijoles.Text = productos[3].PriceText;
            priceAzucar.Text = productos[4].PriceText;

            dataGridView1.DataSource = productos;
        }

        private void priceAvena_Click(object sender, EventArgs e)
        {

        }
    }
}
