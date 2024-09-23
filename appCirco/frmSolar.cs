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
    public partial class frmSolar : Form
    {
        public frmSolar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolar_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtGasto;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtGasto.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha o campo solicitado!");
                return;
            }

            double gasto, resultado, preco;

            gasto = Convert.ToDouble(txtGasto.Text.Trim());
            resultado = gasto / 31.20;
            preco = resultado * 450;

            lblPaineis.Text = "Quantidade de placas: " + resultado.ToString("N0");
            lblPreco.Text = "Valor: " + preco.ToString("C");

            //txtGasto.Text = string.Empty;
            txtGasto.Focus();
            txtGasto.SelectAll();
        }

        private void txtGasto_KeyPress(object sender, KeyPressEventArgs e)
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
