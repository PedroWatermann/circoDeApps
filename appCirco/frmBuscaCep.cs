using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace appCirco
{
    public partial class frmBuscaCep : Form
    {
        public frmBuscaCep()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)144)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void frmBuscaCep_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCep;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var tamanho = txtCep.Text.Trim().Length;
            if (txtCep.Text == string.Empty || tamanho < 8)
            {
                MessageBox.Show("Por favor, digite um CEP válido!");
                txtCep.Text = string.Empty;
                txtCep.Focus();
                return;
            }

            // Cria uma requisição
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{txtCep.Text}/json");
            // Não aceita redirecionamento
            request.AllowAutoRedirect = false;

            // Verifica a resposta do servidor (erro 404)
            HttpWebResponse checaServidor = (HttpWebResponse)request.GetResponse();
            if (checaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível!");
                return;
            }

            using (Stream webStream = checaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();

                        // Retira da variável todos os {} e as ,
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        // Retira "
                        response = response.Replace("\"", "");

                        string[] subString = response.Split('\n');
                        int count = 0;

                        foreach (var subStrings in subString)
                        {
                            if (count == 1)
                            {
                                string[] valor = subStrings.Split(":".ToCharArray());
                                //lblUf.Text = "\"" + valor[0] + "\"" + " / " + "\"" + valor[1] + "\"";
                                if (valor[1] == " true")
                                {
                                    MessageBox.Show("CEP não encontrado!");
                                    txtCep.Text = string.Empty;
                                    txtCep.Focus();
                                    return;
                                }
                            }
                            if (count == 3)
                            {
                                string[] valor = subStrings.Split(":".ToCharArray());
                                lblEndereco.Text = "Endereço: " + valor[1];
                            }
                            if (count == 4)
                            {
                                string[] valor = subStrings.Split(":".ToCharArray());
                                lblComplemento.Text = "Complemento: " + valor[1];
                            }
                            if (count == 5)
                            {
                                string[] valor = subStrings.Split(":".ToCharArray());
                                lblBairro.Text = "Bairro: " + valor[1];
                            }
                            if (count == 6)
                            {
                                string[] valor = subStrings.Split(":".ToCharArray());
                                lblCidade.Text = "Cidade: " + valor[1];
                            }
                            if (count == 7)
                            {
                                string[] valor = subStrings.Split(":".ToCharArray());
                                lblUf.Text = "UF: " + valor[1];
                            }

                            count++;

                            //txtCep.Text = string.Empty;
                            txtCep.Focus();
                            txtCep.SelectAll();
                        }
                    }
                }
            }
        }
    }
}
