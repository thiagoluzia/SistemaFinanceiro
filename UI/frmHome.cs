using BLL;
using DTO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmHome : Form
    {
        ReceitaBLL bll = new ReceitaBLL();
        ReceitaDTO dtoReceita = new ReceitaDTO();

        DespesaBLL bllDespesa = new DespesaBLL();
        DespesaDTO dtoDespesa = new DespesaDTO();


        public FrmHome()
        {
            InitializeComponent();
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            CarregarGridReceita();
            CarregarGridDespesa();
            ValoresLabelDash();
        }

        #region Botões

        private void BtnContas_Click(object sender, EventArgs e)
        {
            frmConta conta = new frmConta();
            conta.ShowDialog();
        }
        private void BtnCategoriaReceita_Click(object sender, EventArgs e)
        {
            FrmCategoriaReceita categoriaReceita = new FrmCategoriaReceita();
            categoriaReceita.ShowDialog();
        }
        private void BtnReceita_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            cadReceita.ShowDialog();
            CarregarGridReceita();
            ValoresLabelDash();
        }
        private void BtnReceitas_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            cadReceita.ShowDialog();
            CarregarGridReceita();
            ValoresLabelDash();
        }

        private void BtnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            FrmCategoriaDespesa categoriaDespesa = new FrmCategoriaDespesa();
            categoriaDespesa.ShowDialog();
        }
        private void BtnDespesa_Click_1(object sender, EventArgs e)
        {
            frmDespesas Despesa = new frmDespesas();
            Despesa.ShowDialog();
            CarregarGridDespesa();
            ValoresLabelDash();
        }
        private void BtnDespesas_Click(object sender, EventArgs e)
        {
            frmDespesas Despesa = new frmDespesas();
            Despesa.ShowDialog();
            ValoresLabelDash();
        }

        #endregion

        #region label links
        private void LnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thiagoluzia");
        }
        private void LnkLinkDin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/thiago-moura/");
        }
        #endregion

        #region Procedimentos

        public void ValoresLabelDash()
        {
            double preco = 0;
            double totalReceita = 0;
            double totalDespesa = 0;
            double despesa = 0;
            double receita = 0;
            double totalGeral = 0;
            //Despesa
            for (int i = 0; i < dgvResumoDespesaHome.Rows.Count; i++)
            {
                preco = Convert.ToDouble(dgvResumoDespesaHome.Rows[i].Cells[2].Value);
                totalDespesa += preco;
                lblDespesas.Text = string.Format(totalDespesa.ToString());
                despesa = totalDespesa;
            }
            //Receita
            for (int i = 0; i < dgvResumoReceitaHome.Rows.Count; i++)
            {
                preco = Convert.ToDouble(dgvResumoReceitaHome.Rows[i].Cells[2].Value);
                totalReceita = totalReceita + preco;
                lblReceitas.Text = string.Format(totalReceita.ToString());
                receita = totalReceita;
            }
            totalGeral = receita - despesa;


            lblReceitas.Text = string.Format(receita.ToString("C"));
            lblDespesas.Text = string.Format(despesa.ToString("C"));
            lblTotalGeral.Text = string.Format(totalGeral.ToString("C"));

            if (receita < despesa)
            {
                panel8.BackgroundImage = global::UI.Properties.Resources.negativo;
                panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));

            }
            else if (receita > despesa)
            {
                panel8.BackgroundImage = global::UI.Properties.Resources.positovo;
                panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(167)))), ((int)(((byte)(80)))));

            }
            else
            {
                panel8.BackgroundImage = global::UI.Properties.Resources.baseline_notification_important_white_36dp;
                panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            }
            if(totalGeral > 0)
            {
                btnPoupar.Visible = true;
            }
            else
            {
                btnPoupar.Visible = false;
            }

        }

        private void CarregarGridReceita()
        {
            DateTime dataAtual = Convert.ToDateTime(dtpData.Text);

            string data = dataAtual.Month.ToString();
            dgvResumoReceitaHome.DataSource = bll.ExibirMes(data);

            //this.dgvResumoReceitaHome.Columns["desc_receita"].Name = "teste"; 

            this.dgvResumoReceitaHome.Columns[0].Visible = false;
            this.dgvResumoReceitaHome.Columns[2].DefaultCellStyle.Format = "C";
            this.dgvResumoReceitaHome.Columns[3].Visible = false;
            this.dgvResumoReceitaHome.Columns[5].Visible = false;
            this.dgvResumoReceitaHome.Columns[6].Visible = false;
            this.dgvResumoReceitaHome.Columns[8].Visible = false;

        }

        private void CarregarGridDespesa()
        {
            DateTime dataAtual = Convert.ToDateTime(dtpData.Text);

            string data = dataAtual.Month.ToString();
            dgvResumoDespesaHome.DataSource = bllDespesa.ExibirMes(data);
            this.dgvResumoDespesaHome.Columns[0].Visible = false;
            this.dgvResumoDespesaHome.Columns[2].DefaultCellStyle.Format = "C";
            this.dgvResumoDespesaHome.Columns[3].Visible = false;
            this.dgvResumoDespesaHome.Columns[5].Visible = false;
            this.dgvResumoDespesaHome.Columns[6].Visible = false;
            this.dgvResumoDespesaHome.Columns[8].Visible = false;
        }

        #endregion

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarGridDespesa();
            CarregarGridReceita();
            ValoresLabelDash();
        }

    }
}
