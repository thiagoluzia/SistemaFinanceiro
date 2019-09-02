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
    public partial class FrmCadDespesa : Form
    {
        public FrmCadDespesa()
        {
            InitializeComponent();
        }

        private void BtnCategoriaDespesa_Click(object sender, EventArgs e)
        {
            FrmCategoriaDespesa categoriaDespesa = new FrmCategoriaDespesa();
            categoriaDespesa.ShowDialog();
        }

        private void BtnSalvarDespesa_Click(object sender, EventArgs e)
        {

        }
    }
}
