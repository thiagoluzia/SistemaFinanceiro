using BLL;
using DTO;
using System;
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
            try
            {
                if (dto.Id > 0)
                {
                    dto.Descricao = txtCadastrarCategoriaReceita.Text;
                    bll.Atualizar(dto);
                    MessageBox.Show("Categoria Atualizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dto.Id = 0;
                }
                else if (txtCadastrarCategoriaReceita.Text == "")
                {
                    MessageBox.Show("Prencha o campo descrição antes de salvar!", "Informmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dto.Descricao = txtCadastrarCategoriaReceita.Text;
                    bll.Inserir(dto);
                    MessageBox.Show("Categoria cadastrada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar salvar um registro! {ex.Message}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dto.Id = 0;
                CarregarGrid();
                LimparCampos();
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                dto.Id = (int)dgvLisCategoriaReceita.CurrentRow.Cells[0].Value;
                txtCadastrarCategoriaReceita.Text = dgvLisCategoriaReceita.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nenhuma categoria foi selecionado: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja realmente excluir essa categoria? Caso ela esteja vinculada a algum lançamento, não poderá ser excluida", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (DialogResult == DialogResult.Yes)
                {
                    dto.Id = (int)dgvLisCategoriaReceita.CurrentRow.Cells[0].Value;
                    dto.Descricao = dgvLisCategoriaReceita.CurrentRow.Cells[1].Value.ToString();
                    bll.Excluir(dto);
                    MessageBox.Show($"Categoria excluida com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nenhuma categoria foi selecionado: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparCampos()
        {
            txtCadastrarCategoriaReceita.Text = String.Empty;
        }
        private void CarregarGrid()
        {
            dgvLisCategoriaReceita.DataSource = bll.Exibir();
        }
    }
}
