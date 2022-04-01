using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmProduct f = new FrmProduct();
            f.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser();
            f.Show();
        }
    }
}
