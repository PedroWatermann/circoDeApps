using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace appCirco
{
    public partial class frmMenu : Form
    {
        public frmMenu(bool showSplash = true)
        {
            InitializeComponent();

            if (showSplash)
            {
                frmSplash splash = new frmSplash();
                splash.Show();
                Application.DoEvents();
                Thread.Sleep(3000);
                splash.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxBuscaCep_Click(object sender, EventArgs e)
        {
            frmBuscaCep buscaCep = new frmBuscaCep();

            this.Hide();
            buscaCep.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            buscaCep.ShowDialog();
        }

        private void lblBuscaCep_Click(object sender, EventArgs e)
        {
            frmBuscaCep buscaCep = new frmBuscaCep();

            this.Hide();
            buscaCep.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            buscaCep.ShowDialog();
        }

        private void pbxViagem_Click(object sender, EventArgs e)
        {
            frmViagem viagem = new frmViagem();

            this.Hide();
            viagem.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            viagem.ShowDialog();
        }

        private void lblViagem_Click(object sender, EventArgs e)
        {
            frmViagem viagem = new frmViagem();

            this.Hide();
            viagem.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            viagem.ShowDialog();
        }

        private void pbxConversorVelocidade_Click(object sender, EventArgs e)
        {
            frmConversorVelocidade conversorVelocidade = new frmConversorVelocidade();

            this.Hide();
            conversorVelocidade.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            conversorVelocidade.ShowDialog();
        }

        private void lblConversorVelocidade_Click(object sender, EventArgs e)
        {
            frmConversorVelocidade conversorVelocidade = new frmConversorVelocidade();

            this.Hide();
            conversorVelocidade.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            conversorVelocidade.ShowDialog();
        }

        private void pbxSolar_Click(object sender, EventArgs e)
        {
            frmSolar solar = new frmSolar();

            this.Hide();
            solar.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            solar.ShowDialog();
        }

        private void lblSolar_Click(object sender, EventArgs e)
        {
            frmSolar solar = new frmSolar();

            this.Hide();
            solar.FormClosed += (s, args) =>
            {
                // Reabre o menu sem a splash screen
                frmMenu menu = new frmMenu(false);
                menu.Show();
            };
            solar.ShowDialog();
        }
    }
}
