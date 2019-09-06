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
            dto.Valor = Convert.ToDouble(DgvListDespesa.CurrentRow.Cells[2].Value);
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
            int id = (int)DgvListDespesa.CurrentRow.Cells[0].Value;
            dto.Id = id;
            bll.Exluir(dto);
            MessageBox.Show("Despesa Exluida com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
        }
        #endregion

        #region Procedimentos
        public void CarregarGrid()
        {
            DgvListDespesa.DataSource = bll.Exibir();
            this.DgvListDespesa.Columns[0].Visible = false;
            this.DgvListDespesa.Columns[3].Visible = false;
            this.DgvListDespesa.Columns[5].Visible = false;
            //txtPesquisarDespesa.Focus();
        }
        #endregion
    }
}
