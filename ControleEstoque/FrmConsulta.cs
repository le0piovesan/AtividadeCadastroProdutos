using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmConsulta : Form
    {
        public int idProduto = 0;
        public FrmConsulta()
        {
            InitializeComponent();
            //ModelProduct m = new ModelProduct();
            //List<DtoProductList> list = m.GetProdutos();
            //dataGridView1.DataSource = list;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ModelProduct m = new ModelProduct();
            List<DtoProductList> list = m.ListProdutosNome(textBox1.Text);
            dataGridView1.DataSource = list;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                idProduto = (Int32)dataGridView1.CurrentRow.Cells[0].Value;
                Close();
            }
        }
    }
}
