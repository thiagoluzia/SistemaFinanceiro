using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmConta : Form
    {
        ContaBLL bll = new ContaBLL();
        ContaDTO dto = new ContaDTO();

        public frmConta()
        {
            InitializeComponent();
        }
        private void frmConta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(dto.Id > 0)
            {
                dto.Descricao = txtDescricaoCadConta.Text;
                bll.Atulaizar(dto);
                MessageBox.Show("Conta atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dto.Id = 0;
            }
            else
            {
                dto.Descricao = txtDescricaoCadConta.Text;
                bll.Inserir(dto);
                MessageBox.Show("Conta adicionada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimparCampos();
            CarregarGrid();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dto.Id = (int)DgvListConta.CurrentRow.Cells[0].Value;
            dto.Descricao = DgvListConta.CurrentRow.Cells[1].Value.ToString();
            bll.Excluir(dto);
            CarregarGrid();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dto.Id = (int)DgvListConta.CurrentRow.Cells[0].Value;
            txtDescricaoCadConta.Text = DgvListConta.CurrentRow.Cells[1].Value.ToString();
        }

        private void LimparCampos()
        {
            txtDescricaoCadConta.Text = "";
        }
        private void CarregarGrid()
        {
            DgvListConta.DataSource = bll.Exibir();
        }
    }
}
