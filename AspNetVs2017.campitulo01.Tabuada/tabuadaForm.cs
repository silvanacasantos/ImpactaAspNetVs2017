using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVs2017.campitulo01.Tabuada
{
    public partial class tabuadaForm : Form
    {
        public tabuadaForm()
        {
            InitializeComponent();
        }

        private void tabuadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                if (e.KeyChar == 13)
                {
                    Calcular();
                }
            }
            else
            {
                //e.Handled = true;
                e.KeyChar = '\0';
            }
        }   
        private void Calcular()
        {
            tabuadaListBox.Items.Clear();

            var tabuada = Convert.ToInt32(tabuadaTextBox.Text);

            for (int i = 0; i <= 10; i++)
            {
                tabuadaListBox.Items.Add($"{tabuada}x {i} = {tabuada * i}");
            }

            tabuadaTextBox.Focus();
            tabuadaTextBox.SelectAll();

        }
    }
}
