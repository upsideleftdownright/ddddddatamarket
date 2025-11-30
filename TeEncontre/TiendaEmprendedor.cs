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
    public partial class TiendaEmprendedor : Form
    {
        public TiendaEmprendedor()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            int precioArrz = random.Next(18, 23);
            price.Text = precioArrz.ToString("C$" + precioArrz + "/lb");

            int precioMaiz = random.Next(13, 16);
            priceMaiz.Text = precioArrz.ToString("C$" + precioMaiz + "/lb");

            int precioAvena = random.Next(19, 23);
            priceAvena.Text = precioArrz.ToString("C$" + precioAvena + "/lb");

            int precioFrijoles = random.Next(25, 35);
            priceFrijoles.Text = precioArrz.ToString("C$" + precioFrijoles + "/lb");

            int precioAzucar = random.Next(15, 19);
            priceAzucar.Text = precioArrz.ToString("C$" + precioAzucar + "/lb");
        }
    }
}
