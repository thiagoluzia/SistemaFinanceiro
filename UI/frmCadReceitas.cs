using BLL;
using DTO;
using System;
using System.Windows.Forms;
using System.Globalization;
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
        }

        FrmHome home;//Com isso, ao salvar uma receita o grid sera atualizdo, pois terei acesso ao metodo atualizar grid
        public FrmCadReceita(FrmHome home)
        {
            this.home = home;
            InitializeComponent();
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
                mskValor.Text = dto.Valor;
                CarregarCombos();//carregar o combo com os dados de update
                cboCategoriaReceita.SelectedValue = dto.CategoriaReceita;
                cboConta.SelectedValue = dto.Conta;
                mskVencimento.Text = dto.DataVencimento.ToString();
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
            try
            {
                ReceitaBLL bll = new ReceitaBLL();
                if (this.dto == null)//Cadastrar
                {
                    ReceitaDTO dto = new ReceitaDTO();
                    dto.Descricao = txtDescricaoReceita.Text;
                    dto.Valor = mskValor.Text;
                    dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
                    dto.Conta = (int)cboConta.SelectedValue;
                    //usar validação caso o usuario nao preencha a data, pegar data atual
                    dto.DataVencimento = Convert.ToDateTime(mskVencimento.Text);
                    dto.Observacao = txtObservacaoReceita.Text;
                    //home.CarregarGridReceita();

                    if (txtDescricaoReceita.Text == "" || mskValor.Text == "" || (int)cboCategoriaReceita.SelectedValue <= 0 || mskVencimento.Text == "")
                    {
                        MessageBox.Show("Não é possivel salvar essa conta, pois campos obrigatorios não foram preencido\n\nPreencha os campos com *.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        bll.Inserir(dto);
                        MessageBox.Show("Receita cadastrada com sucesso! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else//Alterar
                {
                    this.dto.Descricao = txtDescricaoReceita.Text;
                    this.dto.Valor = mskValor.Text;
                    this.dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
                    this.dto.Conta = (int)cboConta.SelectedValue;
                    this.dto.DataVencimento = DateTime.Parse(mskVencimento.Text);
                    this.dto.Observacao = txtObservacaoReceita.Text;
                    bll.Atualizar(this.dto);
                    MessageBox.Show("Receita atualizada com sucesso! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Preencha os campos necessário.{ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                LimparCampos();
            }
           
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            frmConta frm = new frmConta();
            frm.ShowDialog();
        }
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
            cboCategoriaReceita.DisplayMember = "DESCRIÇÃO";
            cboCategoriaReceita.ValueMember = "id";

            cboConta.DataSource = contBll.Exibir();
            cboConta.DisplayMember = "DESCRIÇÃO";
            cboConta.ValueMember = "id";
        }
        private void LimparCampos()
        {
            //txtIdReceita.Text = string.Empty;
            txtDescricaoReceita.Text = string.Empty;
            mskValor.Text = string.Empty;
            CarregarCombos();
            mskVencimento.Text = string.Empty;
            txtObservacaoReceita.Text = string.Empty;
            txtDescricaoReceita.Focus();

        }
        #endregion

        //Trabalhando com mask para valor decimal, ou seja so aceita numero.
        public void mskValor_TextChanged(object sender, EventArgs e)
        {
            //TextChanged ou texto alterado,  neste caso estamos tratando para que seja aceito somente valores numerico, ponto e virgula. Pois os mesmos receberão um tratamento antes de enviar para o banco
            char[] vet = mskValor.Text.ToCharArray();
            string novoValor = "";
            double result = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (double.TryParse(vet[i].ToString(), out result) == true || vet[i].ToString() == "," || vet[i].ToString() == ".")
                {
                    novoValor += vet[i];
                }
            }
            mskValor.Text = novoValor;
            //foi feito no evento MaskInputRejected um procedimento par ao statrt da digitação da direita para esquerda
        }

        private void mskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskValor.SelectionStart = mskValor.Text.Length + 1;
        }

        private void mskValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SEMELHANTE AO QUE O BRENO PASSOU ESTUDAR MELHOR

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("este campo aceita somente numero e virgula");
            //}
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("este campo aceita somente uma virgula");
            //}
        }

        
    }
}
