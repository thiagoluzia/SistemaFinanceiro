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
            dto.Id = (int)DgvCadListReceita.CurrentRow.Cells[0].Value;
            dto.Descricao = DgvCadListReceita.CurrentRow.Cells[1].Value.ToString();
            dto.Valor = Convert.ToDouble(DgvCadListReceita.CurrentRow.Cells[2].Value);
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
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult  = MessageBox.Show("Deseja realmente excluir a receita selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                int id = (int)DgvCadListReceita.CurrentRow.Cells[0].Value;
                dto.Id = id;
                bll.Excluir(dto);
                MessageBox.Show("Receita excluida com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
            }                        
        }
        #endregion

        #region Procedimentos
        public void CarregarGrid()
        {
            DgvCadListReceita.DataSource = bll.Exibir();
            this.DgvCadListReceita.Columns[0].Visible = false;
            this.DgvCadListReceita.Columns[2].DefaultCellStyle.Format = "C";
            this.DgvCadListReceita.Columns[3].Visible = false;
            this.DgvCadListReceita.Columns[5].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string descricao = txtPesquisarReceita.Text;
            DgvCadListReceita.DataSource = bll.Buscar(descricao);
        }
        #endregion
    }
}
