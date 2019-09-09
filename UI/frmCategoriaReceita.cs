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
    public partial class FrmCategoriaReceita : Form
    {
        CategoriaReceitaDTO dto = new CategoriaReceitaDTO();
        CategoriaReceitaBLL bll = new CategoriaReceitaBLL();
        
        public FrmCategoriaReceita()
        {
            InitializeComponent();
        }
        private void FrmCategoriaReceita_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dto.Id > 0)
            {
                dto.Descricao = txtCadastrarCategoriaReceita.Text;
                bll.Atualizar(dto);
                MessageBox.Show("Categoria Atualizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dto.Id = 0;
            }
            else
            {
                dto.Descricao = txtCadastrarCategoriaReceita.Text;
                bll.Inserir(dto);
                MessageBox.Show("Categoria cadastrada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarGrid();
            LimparCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dto.Id = (int)dgvLisCategoriaReceita.CurrentRow.Cells[0].Value;
            txtCadastrarCategoriaReceita.Text = dgvLisCategoriaReceita.CurrentRow.Cells[1].Value.ToString();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja realmente excluir essa categoria? Caso ela esteja vinculada a algum lançamento, não poderá ser excluida", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                dto.Id = (int)dgvLisCategoriaReceita.CurrentRow.Cells[0].Value;
                dto.Descricao = dgvLisCategoriaReceita.CurrentRow.Cells[1].Value.ToString();
                bll.Excluir(dto);
                CarregarGrid();
            }
        }

        private void LimparCampos()
        {
            txtCadastrarCategoriaReceita.Text = "";
        }
        private void CarregarGrid()
        {
            dgvLisCategoriaReceita.DataSource = bll.Exibir();
        }
    }
}
