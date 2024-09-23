using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCirco
{
    public partial class frmViagem : Form
    {
        public frmViagem()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbxCombustivel.Text == "" || txtMedia.Text == string.Empty || txtDistancia.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            double gas, media, distancia, resultado;

            switch (cbxCombustivel.SelectedIndex)
            {
                case 0:
                    gas = 4.08;
                    media = Convert.ToDouble(txtMedia.Text.Trim());
                    distancia = Convert.ToDouble(txtDistancia.Text.Trim());
                    resultado = (distancia / media) * gas;

                    lblResultado.Text = resultado.ToString("C");
                    lblCom.Text = "Combustível: " + cbxCombustivel.Text;
                    lblMed.Text = "Média: " + txtMedia.Text + " Km/l";
                    lblDis.Text = "Distância: " + txtDistancia.Text + " Km";
                    break;
                case 1:
                    gas = 5.99;
                    media = Convert.ToDouble(txtMedia.Text.Trim());
                    distancia = Convert.ToDouble(txtDistancia.Text.Trim());
                    resultado = (distancia / media) * gas;

                    lblResultado.Text = resultado.ToString("C");
                    lblCom.Text = "Combustível: " + cbxCombustivel.Text;
                    lblMed.Text = "Média: " + txtMedia.Text + " Km/l";
                    lblDis.Text = "Distância: " + txtDistancia.Text + " Km";
                    break;
                case 2:
                    gas = 6.13;
                    media = Convert.ToDouble(txtMedia.Text.Trim());
                    distancia = Convert.ToDouble(txtDistancia.Text.Trim());
                    resultado = (distancia / media) * gas;

                    lblResultado.Text = resultado.ToString("C");
                    lblCom.Text = "Combustível: " + cbxCombustivel.Text;
                    lblMed.Text = "Média: " + txtMedia.Text + " Km/l";
                    lblDis.Text = "Distância: " + txtDistancia.Text + " Km";
                    break;
            }

            cbxCombustivel.Focus();
            cbxCombustivel.SelectAll();
        }

        private void frmViagem_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbxCombustivel;
        }

        private void cbxCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
            }
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)144 && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)144 && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.PerformClick();
            }
        }
    }
}
