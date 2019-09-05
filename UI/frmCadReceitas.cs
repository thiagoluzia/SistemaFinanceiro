using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCadReceita : Form
    {
        #region Instancias 
        ReceitaBLL bll = new ReceitaBLL();

        CategoriaReceitaDTO catDto = new CategoriaReceitaDTO();
        CategoriaReceitaBLL catBll = new CategoriaReceitaBLL();

        ContaDTO contDto = new ContaDTO();
        ContaBLL contBll = new ContaBLL();
        #endregion

        public FrmCadReceita()
        {
            InitializeComponent();
            CarregarCombos();
        }

        private ReceitaDTO dto;
        public FrmCadReceita(ReceitaDTO dto)
        {   //este dto vai receber o dto passado por parametro, assim facilita o uso dele internamente
            this.dto = dto;
            InitializeComponent();
        }
        private void FrmCadReceita_Load(object sender, EventArgs e)
        {
            if (this.dto != null)//sinifica que ele esta preenchido, com isso os campos sao preenchidos para update
            {
                txtDescricaoReceita.Text = dto.Descricao;
                txtValorReceita.Text = Convert.ToString(dto.Valor);
                CarregarCombos();//carregar o combo com os dados de update
                cboCategoriaReceita.SelectedValue = dto.CategoriaReceita;
                cboConta.SelectedValue = dto.Conta;
                dtpDataVencimentoReceita.Text = dto.DataVencimento.ToString();
                txtObservacaoReceita.Text = dto.Observacao;
            }
            else
            {
                LimparCampos();
            }
        }

        #region Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ReceitaBLL bll = new ReceitaBLL();
            if (this.dto == null)//Cadastrar
            {
                ReceitaDTO dto = new ReceitaDTO();
                dto.Descricao = txtDescricaoReceita.Text;
                dto.Valor = Convert.ToDouble(txtValorReceita.Text);
                dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
                dto.Conta = (int)cboConta.SelectedValue;
                dto.DataVencimento = DateTime.Parse(dtpDataVencimentoReceita.Text);
                dto.Observacao = txtObservacaoReceita.Text;
                bll.Inserir(dto);
                MessageBox.Show("Receita cadastrada com sucesso! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//Alterar
            {
                this.dto.Descricao = txtDescricaoReceita.Text;
                this.dto.Valor = Convert.ToDouble(txtValorReceita.Text);
                this.dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
                this.dto.Conta = (int)cboConta.SelectedValue;
                this.dto.DataVencimento = DateTime.Parse(dtpDataVencimentoReceita.Text);
                this.dto.Observacao = txtObservacaoReceita.Text;
                bll.Atualizar(this.dto);
                MessageBox.Show("Receita atualizada com sucesso! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            LimparCampos();
        }

        //cadastrar nova categoria no ato de inserir uma receita
        private void BtnCategoriaReceita_Click(object sender, EventArgs e)
        {
            FrmCategoriaReceita categoriaReceita = new FrmCategoriaReceita();
            categoriaReceita.ShowDialog();
            CarregarCombos();
        }
        #endregion

        #region Procedimentos
        private void CarregarCombos()
        {
            cboCategoriaReceita.DataSource = catBll.Exibir();
            cboCategoriaReceita.DisplayMember = "des_categoria_receita";
            cboCategoriaReceita.ValueMember = "id";

            cboConta.DataSource = contBll.Exibir();
            cboConta.DisplayMember = "desc_conta";
            cboConta.ValueMember = "id";
        }

        private void LimparCampos()
        {
            txtIdReceita.Text = string.Empty;
            txtDescricaoReceita.Text = string.Empty;
            txtValorReceita.Text = string.Empty;
            CarregarCombos();
            dtpDataVencimentoReceita.Text = string.Empty;
            txtObservacaoReceita.Text = string.Empty;
            txtDescricaoReceita.Focus();

        }
        #endregion
    }
}
