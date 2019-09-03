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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadReceita receita = new FrmCadReceita();
            receita.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void FrmReceitas_Load(object sender, EventArgs e)
        {
            DgvCadListReceita.DataSource = bll.Exibir();
        }
    }
}
