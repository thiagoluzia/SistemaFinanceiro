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
    public partial class FrmReceitas : Form
    {
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
    }
}
