using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var valorPago = Convert.ToDecimal(valorPagotextBox.Text);
            var valorCompra = decimal.Parse(valorCompratextBox.Text);

            var troco = valorPago - valorCompra;

            //TrocotextBox.Text = Convert.ToString(troco);
            TrocotextBox.Text = troco.ToString("c");  // ("c") - tipo currence ou seja moeda.

            var moedas1 = (int)(troco/1); // (int) é um cast
            troco = troco % 1;

            var moedas050 = (int)(troco / 0.50m); 
            troco = troco % 0.50m;

            var moedas025 = (int)(troco / 0.25m); 
            troco %= 0.25m;

            var moedas010 = (int)(troco / 0.10m); 
            troco %= 0.10m;

            var moedas005 = (int)(troco / 0.05m); 
            troco %= 0.05m;

            var moedas001 = (int)(troco / 0.01m); 
            troco %= 0.01m;

            moedaslistView.Items[0].Text = moedas1.ToString();
            moedaslistView.Items[1].Text = moedas050.ToString();
            moedaslistView.Items[2].Text = moedas025.ToString();
            moedaslistView.Items[3].Text = moedas010.ToString();
            moedaslistView.Items[4].Text = moedas005.ToString();
            moedaslistView.Items[5].Text = moedas001.ToString();
        }
    }
}
