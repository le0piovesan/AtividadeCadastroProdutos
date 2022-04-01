using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmProduct : ControleEstoque.FrmBase
    {
        public FrmProduct()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ModelProduct model = new ModelProduct();
            List<DtoProductList> list = model.GetProdutos();
            gridProdutos.DataSource = list;
        }

        public void LimparCampos()
        {
            textID.Text = String.Empty;
            textNome.Text = String.Empty;
            textUnidade.Text = String.Empty;
            textQuantidade.Text = String.Empty;
            textPreco.Text = String.Empty;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModelProduct model = new ModelProduct();
            DtoProduct p = new DtoProduct
            {
                nome = textNome.Text,
                unidade = textUnidade.Text,
                quantidade = int.Parse(textQuantidade.Text),
                preco = decimal.Parse(textPreco.Text),

            };


            if (textID.Text == String.Empty)
                model.SetProduto(p);
            else
                p.id = int.Parse(textID.Text);
            model.EditarProduto(p);

            LimparCampos();
            DesabilitarText();
            CarregarGrid();
        }

        private void DesabilitarText()
        {
            textNome.Enabled = false;
            textUnidade.Enabled = false;
            textQuantidade.Enabled = false;
            textPreco.Enabled = false;
          
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarText();
            textNome.Focus();
        }

        private void HabilitarText()
        {
            textNome.Enabled = true;
            textUnidade.Enabled = true;
            textQuantidade.Enabled = true;
            textPreco.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textID.Text == String.Empty)
            {
                FrmAlert f = new FrmAlert();
                f.Show();
            }
            else
            {
                HabilitarText();
                textNome.Focus();
            }
            
        }

        private void gridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gridProdutos.CurrentRow.Cells[0].Value;
            ModelProduct model = new ModelProduct();

            DtoProduct produto = model.GetProduto(id);

            textID.Text = produto.id.ToString();
            textNome.Text = produto.nome;
            textUnidade.Text = produto.unidade;
            textQuantidade.Text = produto.quantidade.ToString();
            textPreco.Text = produto.preco.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ModelProduct model = new ModelProduct();
            if(textID.Text == String.Empty)
            {
                FrmAlert f = new FrmAlert();
                f.Show();
            }
            else
            {
                model.DeletarProduto(int.Parse(textID.Text));
                CarregarGrid();
                LimparCampos();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarText();
        }
    }
}
