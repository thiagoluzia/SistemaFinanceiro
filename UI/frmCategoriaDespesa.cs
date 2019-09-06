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
    public partial class FrmCategoriaDespesa : Form
    {
        CategoriaDespesaDTO dto = new CategoriaDespesaDTO();
        CategoriaDespesaBLL bll = new CategoriaDespesaBLL();

        public FrmCategoriaDespesa()
        {
            InitializeComponent();
        }
        private void FrmCategoriaDespesa_Load(object sender, EventArgs e)
        {
            CarregarCategoriasDespesa();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dto.Id > 0)
            {
                dto.Id = (int)dgvListDespesa.CurrentRow.Cells[0].Value;
                dto.Descricao = txtCadastrarDespesaReceita.Text;
                bll.AtualizarCategoria(dto);
                MessageBox.Show("Categoria Atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dto.Id = 0;
            }
            else
            {
                dto.Descricao = txtCadastrarDespesaReceita.Text;
                bll.InserirCategoria(dto);
                MessageBox.Show("Categoria Cadastrada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarCategoriasDespesa();
            LimparCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dto.Id = (int)dgvListDespesa.CurrentRow.Cells[0].Value;
            txtCadastrarDespesaReceita.Text = dgvListDespesa.CurrentRow.Cells[1].Value.ToString();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dto.Id = (int)dgvListDespesa.CurrentRow.Cells[0].Value;
            dto.Descricao = dgvListDespesa.CurrentRow.Cells[1].ToString();
            bll.Excluir(dto);
            CarregarCategoriasDespesa();
        }

        private void CarregarCategoriasDespesa()
        {
            dgvListDespesa.DataSource = bll.Exibir();
        }
        private void LimparCampos()
        {
            txtCadastrarDespesaReceita.Text = "";
        }
    }
}
