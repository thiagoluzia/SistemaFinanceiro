using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmDespesas : Form
    {
        #region instancias
        DespesaBLL bll = new DespesaBLL();
        DespesaDTO dto = new DespesaDTO();
        #endregion

        public frmDespesas()
        {
            InitializeComponent();
        }
        private void frmDespesas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        #region Botões
        private void BtnCadDespesa_Click(object sender, EventArgs e)
        {
            FrmCadDespesa despesa = new FrmCadDespesa();
            despesa.ShowDialog();
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dto.Id = Convert.ToInt32(DgvListDespesa.CurrentRow.Cells[0].Value);
            dto.Descricao = DgvListDespesa.CurrentRow.Cells[1].Value.ToString();
            dto.Valor = DgvListDespesa.CurrentRow.Cells[2].Value.ToString() ;
            //cbo Despesa
            dto.CategoriaDespesa = (int)DgvListDespesa.CurrentRow.Cells[3].Value;
            dto.DescCategoria = DgvListDespesa.CurrentRow.Cells[4].Value.ToString();
            //cbo Conta
            dto.Conta = (int)DgvListDespesa.CurrentRow.Cells[5].Value;
            dto.DescConta = DgvListDespesa.CurrentRow.Cells[6].Value.ToString();
            dto.DataVencimanto = Convert.ToDateTime(DgvListDespesa.CurrentRow.Cells[7].Value);
            dto.Observacao = DgvListDespesa.CurrentRow.Cells[8].Value.ToString();

            FrmCadDespesa alterarDespesa = new FrmCadDespesa(dto);
            alterarDespesa.ShowDialog();
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja relamente excluir a despesa selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (DialogResult == DialogResult.Yes)
                {
                    int id = (int)DgvListDespesa.CurrentRow.Cells[0].Value;
                    dto.Id = id;
                    bll.Exluir(dto);
                    MessageBox.Show("Despesa Exluida com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Nenhum registro foi selecionado para ser excluido\nSelecione um registro e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisarDespesa.Focus();
            }
            
        }

        private void btnPesquisarDespesa_Click(object sender, EventArgs e)
        {
            string descricao = txtPesquisarDespesa.Text;
            DgvListDespesa.DataSource = bll.Buscar(descricao);
        }
        #endregion

        #region Procedimentos
        public void CarregarGrid()
        {
            DateTime dataAtual = Convert.ToDateTime(dtpData.Text);
            string data = dataAtual.Month.ToString();


            DgvListDespesa.DataSource = bll.ExibirMes(data);
            this.DgvListDespesa.Columns[0].Visible = false;
            this.DgvListDespesa.Columns[2].DefaultCellStyle.Format = "C";
            this.DgvListDespesa.Columns[3].Visible = false;
            this.DgvListDespesa.Columns[5].Visible = false;
            //txtPesquisarDespesa.Focus();
        }

        private void txtPesquisarDespesa_TextChanged(object sender, EventArgs e)
        {
            string descricao = txtPesquisarDespesa.Text;
            DgvListDespesa.DataSource = bll.Buscar(descricao);
        }

        #endregion

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
