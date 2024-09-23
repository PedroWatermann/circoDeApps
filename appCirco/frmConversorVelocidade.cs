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
    public partial class frmConversorVelocidade : Form
    {
        public frmConversorVelocidade()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVelocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)144 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnConverter.PerformClick();
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (cbxDe.Text == "" || cbxPara.Text == "" || txtVelocidade.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            double velocidade, resultado;
            int de, para;

            velocidade = Convert.ToDouble(txtVelocidade.Text);
            de = cbxDe.SelectedIndex;
            para = cbxPara.SelectedIndex;

            // 0 - Milha por hora (mph)
            // 1 - Pés por segundo (fps)
            // 2 - Metro por segundo (m/s)
            // 3 - Quilômetro por hora (km/h)
            // 4 - Nó (kn)

            switch (de)
            {
                case 0:
                    switch (para)
                    {
                        case 0:
                            resultado = velocidade;
                            lblVel.Text = "Velocidade: " + resultado + " mph";
                            break;
                        case 1:
                            resultado = velocidade * 1.467;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " fps";
                            break;
                        case 2:
                            resultado = velocidade / 2.237;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " m/s";
                            break;
                        case 3:
                            resultado = velocidade * 1.609;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " km/h";
                            break;
                        case 4:
                            resultado = velocidade / 1.151;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " kn";
                            break;
                    }
                    break;
                case 1:
                    switch (para)
                    {
                        case 0:
                            resultado = velocidade / 1.467;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " mph";
                            break;
                        case 1:
                            resultado = velocidade;
                            lblVel.Text = "Velocidade: " + resultado + " fps";
                            break;
                        case 2:
                            resultado = velocidade / 3.281;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " m/s";
                            break;
                        case 3:
                            resultado = velocidade * 1.097;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " km/h";
                            break;
                        case 4:
                            resultado = velocidade / 1.688;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " kn";
                            break;
                    }
                    break;
                case 2:
                    switch (para)
                    {
                        case 0:
                            resultado = velocidade * 2.237;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " mph";
                            break;
                        case 1:
                            resultado = velocidade * 3.281;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " fps";
                            break;
                        case 2:
                            resultado = velocidade;
                            lblVel.Text = "Velocidade: " + resultado + " m/s";
                            break;
                        case 3:
                            resultado = velocidade * 3.6;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " km/h";
                            break;
                        case 4:
                            resultado = velocidade * 1.944;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " kn";
                            break;
                    }
                    break;
                case 3:
                    switch (para)
                    {
                        case 0:
                            resultado = velocidade / 1.609;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " mph";
                            break;
                        case 1:
                            resultado = velocidade / 1.097;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " fps";
                            break;
                        case 2:
                            resultado = velocidade / 3.6;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " m/s";
                            break;
                        case 3:
                            resultado = velocidade;
                            lblVel.Text = "Velocidade: " + resultado + " km/h";
                            break;
                        case 4:
                            resultado = velocidade / 1.852;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " kn";
                            break;
                    }
                    break;
                case 4:
                    switch (para)
                    {
                        case 0:
                            resultado = velocidade * 1.151;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " mph";
                            break;
                        case 1:
                            resultado = velocidade * 1.688;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " fps";
                            break;
                        case 2:
                            resultado = velocidade / 1.944;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " m/s";
                            break;
                        case 3:
                            resultado = velocidade * 1.852;
                            lblVel.Text = "Velocidade: " + resultado.ToString("N2") + " km/h";
                            break;
                        case 4:
                            resultado = velocidade;
                            lblVel.Text = "Velocidade: " + resultado + " kn";
                            break;
                    }
                    break;
            }

            txtVelocidade.Focus();
            txtVelocidade.SelectAll();
        }

        private void txtVelocidade_Click(object sender, EventArgs e)
        {
            lblVel.Text = string.Empty;
        }

        private void frmConversorVelocidade_Load(object sender, EventArgs e)
        {
            txtVelocidade.Focus();
        }
    }
}
