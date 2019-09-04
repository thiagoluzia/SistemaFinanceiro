using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UI
{
    public partial class FrmReceitas : Form
    {
        ReceitaBLL bll = new ReceitaBLL();
        ReceitaDTO dto = new ReceitaDTO();

        public FrmReceitas()
        {
            InitializeComponent();
        }
        private void FrmReceitas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FrmCadReceita frm = new FrmCadReceita();
        }

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
           // dto.Valor = (double)DgvCadListReceita.CurrentRow.Cells[2].Value;
            //dto.CategoriaReceita = (int)DgvCadListReceita.CurrentRow.Cells[3].Value;
            //dto.Conta = (int)DgvCadListReceita.CurrentRow.Cells[4].Value;
            dto.DataVencimento = (DateTime)DgvCadListReceita.CurrentRow.Cells[5].Value;
            dto.Observacao = DgvCadListReceita.CurrentRow.Cells[6].Value.ToString();
            FrmCadReceita frm = new FrmCadReceita(dto);

            frm.ShowDialog();
            CarregarGrid();

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CarregarDto();
            bll.Excluir(dto);
        }

        public void CarregarGrid()
        {
            DgvCadListReceita.DataSource = bll.Exibir();
            this.DgvCadListReceita.Columns[0].Visible = false;
        }
        public void CarregarDto()
        {
            dto.Id = (int)DgvCadListReceita.CurrentRow.Cells[0].Value;
            dto.Descricao = DgvCadListReceita.CurrentRow.Cells[1].Value.ToString();
            dto.Valor = Convert.ToDouble(DgvCadListReceita.CurrentRow.Cells[2].Value);
            dto.CategoriaReceita = Convert.ToInt32(DgvCadListReceita.CurrentRow.Cells[3].Value.ToString());
            dto.Conta = Convert.ToInt32(DgvCadListReceita.CurrentRow.Cells[4].Value.ToString());
            dto.DataVencimento = Convert.ToDateTime(DgvCadListReceita.CurrentRow.Cells[5].Value.ToString());
            dto.Observacao = DgvCadListReceita.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
