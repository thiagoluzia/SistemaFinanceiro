using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmHome : Form
    {
        #region Objetos de BLL e DTO
        ReceitaBLL bll = new ReceitaBLL();
        ReceitaDTO dtoReceita = new ReceitaDTO();

        DespesaBLL bllDespesa = new DespesaBLL();
        DespesaDTO dtoDespesa = new DespesaDTO();
        #endregion

        public FrmHome()
        {
            InitializeComponent();
        }
        //frmDespesas despesa;
        //public FrmHome(frmDespesas despesa)
        //{
        //    this.despesa = despesa;
        //    InitializeComponent();
        //}
        private void FrmHome_Load(object sender, EventArgs e)
        {
            CarregarGridReceita();
            CarregarGridDespesa();
            ValoresLabelDash();
        }

        #region Botões
        //Dashboard
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarGridDespesa();
            CarregarGridReceita();
            ValoresLabelDash();
        }
        private void BtnReceita_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            Form frm = Application.OpenForms["FrmReceitas"];
            if(frm != null)
            {
                frm.Close();
                cadReceita.Show();
            }
            else
            {
                cadReceita.Show();
                CarregarGridReceita();
                ValoresLabelDash();
            }
        }
        private void BtnDespesa_Click_1(object sender, EventArgs e)
        {
            frmDespesas Despesa = new frmDespesas();
            Form frm = Application.OpenForms["frmDespesas"];
            if(frm != null)
            {
                frm.Close();
            }
            else
            {
                Despesa.Show();
                CarregarGridDespesa();
                ValoresLabelDash();
            } 
        }
       
        //Menu
        private void BtnContas_Click(object sender, EventArgs e)
        {
            frmConta conta = new frmConta();
            Form cad = Application.OpenForms["frmConta"];
            if(cad != null)
            {
                cad.Close();
            }
            conta.Show();
        }
        private void BtnCategoriaReceita_Click(object sender, EventArgs e)
        {
            FrmCategoriaReceita categoriaReceita = new FrmCategoriaReceita();

            Form cad = Application.OpenForms["FrmCategoriaReceita"];
            if (cad != null)
            {
                cad.Close();
            }
            categoriaReceita.Show();
        }
        private void BtnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            FrmCategoriaDespesa categoriaDespesa = new FrmCategoriaDespesa();

            Form cad = Application.OpenForms["FrmCategoriaDespesa"];
            if (cad != null)
            {
                cad.Close();
            }
            categoriaDespesa.Show();
        }
        private void BtnReceitas_Click(object sender, EventArgs e)
        {
            FrmReceitas cadReceita = new FrmReceitas();
            cadReceita.ShowDialog();
            CarregarGridReceita();
            ValoresLabelDash();
        }
        private void BtnDespesas_Click(object sender, EventArgs e)
        {
            frmDespesas cadDespesa = new frmDespesas();
            cadDespesa.ShowDialog();
            CarregarGridDespesa();
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
            if (totalGeral > 0)
            {
                btnPoupar.Visible = true;
            }
            else
            {
                btnPoupar.Visible = false;
            }

        }
        public void CarregarGridReceita()
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
        private void CarregarCombo()
        {


        }
        #endregion
    }
}
