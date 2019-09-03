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

        private void BtnCategoriaReceita_Click(object sender, EventArgs e)
        {
            FrmCategoriaReceita categoriaReceita = new FrmCategoriaReceita();
            categoriaReceita.ShowDialog();
        }

        private void PnlCadReceita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCadReceita_Load(object sender, EventArgs e)
        {
            //carrega o combo box categoria
            cboCategoriaReceita.DataSource = catBll.Exibir();
            cboCategoriaReceita.DisplayMember = "des_categoria_receita";
            cboCategoriaReceita.ValueMember = "id";

            
            //cboCategoriaReceita.DataValueField = "id";
            //cboCategoriaReceita.DataBind();

            //carrega o combo box conta
            cboConta.DataSource = contBll.Exibir();
            cboConta.DisplayMember = "desc_conta";
            cboConta.ValueMember = "id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dto.Descricao = txtDescricaoReceita.Text;
            dto.Valor = double.Parse(txtValorReceita.Text);
            
            dto.CategoriaReceita = cboCategoriaReceita.SelectedIndex;
            dto.Conta = cboConta.SelectedIndex;
            dto.DataVencimento = DateTime.Parse(dtpDataVencimentoReceita.Text);
            dto.Observacao = txtObservacaoReceita.Text;
            bll.Inserir(dto);
        }
    }
}
