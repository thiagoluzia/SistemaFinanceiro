using BLL;
using DTO;
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
    public partial class FrmCadReceita : Form
    {
        ReceitaBLL bll = new ReceitaBLL();
        ReceitaDTO dto = new ReceitaDTO();

        CategoriaReceitaDTO catDto = new CategoriaReceitaDTO();
        CategoriaReceitaBLL catBll = new CategoriaReceitaBLL();

        ContaDTO contDto = new ContaDTO();
        ContaBLL contBll = new ContaBLL();

        public FrmCadReceita()
        {
            InitializeComponent();
        }
        public FrmCadReceita(ReceitaDTO dto)
        {
            InitializeComponent();
            txtDescricaoReceita.Text = dto.Descricao;
            txtValorReceita.Text = Convert.ToString(dto.Valor);
            cboCategoriaReceita.SelectedValue = dto.CategoriaReceita.ToString();
            cboConta.SelectedValue = dto.Conta;
            dtpDataVencimentoReceita.Text = dto.DataVencimento.ToString();
            txtObservacaoReceita.Text = dto.Observacao;
        }
        private void FrmCadReceita_Load(object sender, EventArgs e)
        {
            CarregarCombos();
        }

        private void BtnCategoriaReceita_Click(object sender, EventArgs e)
        {
            FrmCategoriaReceita categoriaReceita = new FrmCategoriaReceita();
            categoriaReceita.ShowDialog();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (dto.Id > 0)
            {

                dto.Descricao = txtDescricaoReceita.Text;
                dto.Valor = double.Parse(txtValorReceita.Text);
                dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
                dto.Conta = (int)cboConta.SelectedValue;
                dto.DataVencimento = DateTime.Parse(dtpDataVencimentoReceita.Text);
                dto.Observacao = txtObservacaoReceita.Text;
                bll.Atualizar(dto);
            }
            else
            {

                dto.Descricao = txtDescricaoReceita.Text;
                dto.Valor = double.Parse(txtValorReceita.Text);
                dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
                dto.Conta = (int)cboConta.SelectedValue;
                dto.DataVencimento = DateTime.Parse(dtpDataVencimentoReceita.Text);
                dto.Observacao = txtObservacaoReceita.Text;
                bll.Inserir(dto);
            }
            LimparCampos();
        }

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
        //private void DtoPreenchido()
        //{
        //    dto.Descricao = txtDescricaoReceita.Text;
        //    dto.Valor = double.Parse(txtValorReceita.Text);
        //    dto.CategoriaReceita = (int)cboCategoriaReceita.SelectedValue;
        //    dto.Conta = (int)cboConta.SelectedValue;
        //    dto.DataVencimento = DateTime.Parse(dtpDataVencimentoReceita.Text);
        //    dto.Observacao = txtObservacaoReceita.Text;

        //}
        private void LimparCampos()
        {
            txtDescricaoReceita.Text = "";
            txtValorReceita.Text = "";
            //cboCategoriaReceita.SelectedValue = null;
            //cboConta.SelectedValue = null;
            dtpDataVencimentoReceita.Text = "";
            txtObservacaoReceita.Text = "";

            dto.Id = 0;
        }
        private void CarregarCampos()
        {
            
        }
        #endregion
    }
}
