using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmReceitas : Form
    {
        #region Instancias
        ReceitaBLL bll = new ReceitaBLL();
        ReceitaDTO dto = new ReceitaDTO();
        #endregion

        public FrmReceitas()
        {
            InitializeComponent();
        }

        private void FrmReceitas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FrmCadReceita frm = new FrmCadReceita();
        }

        #region Botões
        private void CadReceita_Click(object sender, EventArgs e)
        {
            FrmCadReceita receita = new FrmCadReceita();
            receita.ShowDialog();
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                dto.Id = (int)DgvCadListReceita.CurrentRow.Cells[0].Value;
                dto.Descricao = DgvCadListReceita.CurrentRow.Cells[1].Value.ToString();
                dto.Valor = DgvCadListReceita.CurrentRow.Cells[2].Value.ToString();
                //novo caso
                dto.CategoriaReceita = (int)DgvCadListReceita.CurrentRow.Cells[3].Value;
                dto.DescCategoria = DgvCadListReceita.CurrentRow.Cells[4].Value.ToString();
                //novo Caso
                dto.Conta = (int)DgvCadListReceita.CurrentRow.Cells[5].Value;
                dto.DescConta = DgvCadListReceita.CurrentRow.Cells[6].Value.ToString();
                dto.DataVencimento = (DateTime)DgvCadListReceita.CurrentRow.Cells[7].Value;
                dto.Observacao = DgvCadListReceita.CurrentRow.Cells[8].Value.ToString();

                FrmCadReceita frm = new FrmCadReceita(dto);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nenhum lançamento foi selecionado. \nSelecione um lançamento para que possa ser feita a alteração:", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja realmente excluir a receita selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (DialogResult == DialogResult.Yes)
                {
                    int id = (int)DgvCadListReceita.CurrentRow.Cells[0].Value;
                    dto.Id = id;
                    bll.Excluir(dto);
                    MessageBox.Show("Receita excluida com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
            catch (Exception NullReferenceException)
            {

                MessageBox.Show($"Nenhum registro foi selecionado para ser excluido\nSelecione um registro e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisarReceita.Focus();
            }


        }
        #endregion

        #region Procedimentos
        public void CarregarGrid()
        {
            DateTime dataAtual = Convert.ToDateTime(dtpData.Text);
            string data = dataAtual.Month.ToString();

            DgvCadListReceita.DataSource = bll.ExibirMes(data);
            this.DgvCadListReceita.Columns[0].Visible = false;
            this.DgvCadListReceita.Columns[2].DefaultCellStyle.Format = ("C");
            this.DgvCadListReceita.Columns[3].Visible = false;
            this.DgvCadListReceita.Columns[5].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string descricao = txtPesquisarReceita.Text;
            DgvCadListReceita.DataSource = bll.Buscar(descricao);
        }
        #endregion

        private void txtPesquisarReceita_TextChanged(object sender, EventArgs e)
        {
            string descricao = txtPesquisarReceita.Text;
            DgvCadListReceita.DataSource = bll.Buscar(descricao);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
