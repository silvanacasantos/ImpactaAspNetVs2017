using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.capitulo01.Fretes
{
    public partial class FretesForm : Form
    {
        public FretesForm()

        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            //if (!erros.Any())
            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine,erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(ValorTextBox.Text);
            var nordeste = new List<string> {"PE","BA","AL"};

            switch (UFComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;

                case "ES":
                case "RJ":
                    percentual = 0.3m;
                    break;

                case "MG":
                    percentual = 0.35m;
                    break;

                case "AM":
                    percentual = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf):
                    percentual = 0.4m;
                    break;
                case null:
                    throw new NullReferenceException("A UF não pode ser nula.");
                default:
                    percentual = 0.75m;
                    break;
            }
            FreteTextBox.Text = percentual.ToString("p2");
            TotalTextBox.Text = (valor * (1 + percentual)).ToString("c");
        }
        
        //Realiza a validação do formlario
        private List<String> ValidarFormulario()
        {
            var erros = new List<string>();

            if (ClienteTextBox.Text.Trim() == string.Empty)
            {
                erros.Add("O campo Cliente é obrigatório");
            }
            if (string.IsNullOrEmpty(ValorTextBox.Text.Trim()))
            {
                erros.Add("O campo Valor é obrigatório");
            }
            else
            {
                //para o vs 2015
                //decimal valor;  (é obrigatorio declarar a variavel)
                //if (decimal.TryParse(ValorTextBox.Text.Trim(),out valor))
                  
                    if (!decimal.TryParse(ValorTextBox.Text.Trim(),out decimal valor))
                {
                    erros.Add("O campo Valor está com o formato inválido");
                }
            }

            if (UFComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione a UF de Destino");

            }



            return erros;
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            //ClienteTextBox.Text = "";
            //ValorTextBox.Text = "";
            //UFComboBox.Text = "";
            //FreteTextBox.Text = "";
            //TotalTextBox.Text = "";
            //or
            ClienteTextBox.Text = string.Empty;
            UFComboBox.SelectedIndex = -1;
            ValorTextBox.Clear();
            FreteTextBox.Text = null;
            TotalTextBox.Text = "";

            ClienteTextBox.Focus();


                    }
    }

}
