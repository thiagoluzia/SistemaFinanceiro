using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCadDespesa : Form
    {
        #region Instancias
        DespesaBLL bll = new DespesaBLL();

        CategoriaDespesaDTO catDto = new CategoriaDespesaDTO();
        CategoriaDespesaBLL catBll = new CategoriaDespesaBLL();

        ContaDTO contaDto = new ContaDTO();
        ContaBLL contaBll = new ContaBLL();
        #endregion

        public FrmCadDespesa()
        {
            InitializeComponent();
        }

        private DespesaDTO dto;
        public FrmCadDespesa(DespesaDTO dto)
        {
            this.dto = dto;
            InitializeComponent();
        }
        private void FrmCadDespesa_Load(object sender, EventArgs e)
        {
            if (this.dto != null)
            {
                txtDescricaoDespesa.Text = dto.Descricao;
                mskValor.Text = Convert.ToString(dto.Valor);
                CarregarCombos();
                cboCategoriaDespesa.SelectedValue = dto.CategoriaDespesa;
                cboConta.SelectedValue = dto.Conta;
                mskVencimento.Text = dto.DataVencimanto.ToString();
                txtObservacaoDespesa.Text = dto.Observacao.ToString();
            }
            else
            {
                LimparCampos();
            }
        }

        #region Botões
        private void BtnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            FrmCategoriaDespesa categoriaDespesa = new FrmCategoriaDespesa();
            categoriaDespesa.ShowDialog();
            CarregarCombos();
        }

        private void BtnSalvarDespesa_Click(object sender, EventArgs e)
        {
            DespesaBLL bll = new DespesaBLL();
            if (this.dto == null)//cadastrar
            {
                DespesaDTO dto = new DespesaDTO();
                dto.Descricao = txtDescricaoDespesa.Text;
                dto.Valor = mskValor.Text;
                dto.CategoriaDespesa = (int)cboCategoriaDespesa.SelectedValue;
                dto.Conta = (int)cboConta.SelectedValue;
                dto.DataVencimanto = Convert.ToDateTime(mskVencimento.Text);
                dto.Observacao = txtObservacaoDespesa.Text;
                bll.Inserir(dto);
                LimparCampos();
                MessageBox.Show("Despesa cadastrada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricaoDespesa.Focus();
            }
            else//alterar
            {
                this.dto.Descricao = txtDescricaoDespesa.Text;
                this.dto.Valor = mskValor.Text;
                this.dto.CategoriaDespesa = (int)cboCategoriaDespesa.SelectedValue;
                this.dto.Conta = (int)cboConta.SelectedValue;
                this.dto.DataVencimanto = Convert.ToDateTime(mskVencimento.Text);
                this.dto.Observacao = txtObservacaoDespesa.Text;
                bll.Atualizar(this.dto);
                LimparCampos();
                this.Close();
            }
        }
        #endregion

        #region Procedimentos
        private void CarregarCombos()
        {
            cboCategoriaDespesa.DataSource = catBll.Exibir();
            cboCategoriaDespesa.DisplayMember = "DESCRIÇÃO";
            cboCategoriaDespesa.ValueMember = "id";


            cboConta.DataSource = contaBll.Exibir();
            cboConta.DisplayMember = "DESCRIÇÃO";
            cboConta.ValueMember = "id";
        }

        private void LimparCampos()
        {
            txtDescricaoDespesa.Text = string.Empty;
            mskValor.Text = string.Empty;
            CarregarCombos();
            mskVencimento.Text = string.Empty;
            txtObservacaoDespesa.Text = string.Empty;
        }

        #endregion

        private void mskValor_TextChanged(object sender, EventArgs e)
        {
            char[] vet = mskValor.Text.ToCharArray();
            string novoValor = "";
            double result = 0;
            for(int i = 0; i < vet.Length; i++)
            {
                if (double.TryParse(vet[i].ToString(), out result) == true || vet[i].ToString() == "." || vet[i].ToString() == "," )
                    novoValor += vet[i];
            }
            mskValor.Text = novoValor;
        }

        private void mskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskValor.SelectionStart = mskValor.Text.Length + 1;
        }
    }
}
