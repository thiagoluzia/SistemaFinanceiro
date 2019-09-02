using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
        private void BtnReceitas_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            cadReceita.ShowDialog();
        }

        private void BtnDespesas_Click(object sender, EventArgs e)
        {
            frmDespesas Despesa = new frmDespesas();
            Despesa.ShowDialog();
        }

        private void BtnReceitaPainel_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            cadReceita.ShowDialog();
        }

        private void BtnCategoriaReceita_Click(object sender, EventArgs e)
        {
            FrmCategoriaReceita categoriaReceita = new FrmCategoriaReceita();
            categoriaReceita.ShowDialog();
        }

        private void BtnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            FrmCategoriaDespesa categoriaDespesa = new FrmCategoriaDespesa();
            categoriaDespesa.ShowDialog();
        }

        private void BtnContas_Click(object sender, EventArgs e)
        {
            frmConta conta = new frmConta();
            conta.ShowDialog();
        }

        private void BtnReceita_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            cadReceita.ShowDialog();
        }
        private void BtnDespesa_Click_1(object sender, EventArgs e)
        {
            frmDespesas Despesa = new frmDespesas();
            Despesa.ShowDialog();
        }

        private void LnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thiagoluzia");
        }

        private void LnkLinkDin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/thiago-moura/");
        }
    }
}
