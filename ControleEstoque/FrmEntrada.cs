using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmEntrada : ControleEstoque.FrmBase
    {
        public FrmEntrada()
        {
            InitializeComponent();
            ModelProduct model = new ModelProduct();
            dataGridViewEntrada.DataSource = model.ListProdutosEntrada();

            textBoxidProduto.Enabled = false;
            textBoxQuantidade.Enabled = false;
            textBoxUnitario.Enabled = false;
            textBoxTotal.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto != 0)
            {
#pragma warning disable CS1690 // Acessar um membro em um campo de uma classe de marshaling por referência pode gerar uma exceção de tempo de execução
                textBoxProduto.Text = c.idProduto.ToString();
#pragma warning restore CS1690 // Acessar um membro em um campo de uma classe de marshaling por referência pode gerar uma exceção de tempo de execução
                textBoxProduto.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            ModelProduct get = new ModelProduct();
            DtoProduct produto = get.GetProduto(int.Parse(textBoxProduto.Text));
            textBoxNomeProduto.Text = produto.nome;
        }

        private void textBoxVlrUnitario_Leave(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(textBoxQuantidade.Text) * decimal.Parse(textBoxUnitario.Text);
            textBoxTotal.Text = total.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModelProduct model = new ModelProduct();
            DtoEntrada entrada = new DtoEntrada();
            //entrada.idproduto = int.Parse(textBoxidProduto.Text);
            entrada.qteproduto = int.Parse(textBoxQuantidade.Text);
            entrada.vlrcustoproduto = decimal.Parse(textBoxUnitario.Text);
            entrada.vlrtotalproduto = decimal.Parse(textBoxTotal.Text);
            entrada.dtcompra = DateTime.Now;
            model.SetEntradaProduto(entrada);

            textBoxidProduto.Text = "";
            textBoxQuantidade.Text = "";
            textBoxUnitario.Text = "";
            textBoxTotal.Text = "";

            dataGridViewEntrada.DataSource = model.ListProdutosEntrada();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //textBoxidProduto.Enabled = true;
            textBoxQuantidade.Enabled = true;
            textBoxUnitario.Enabled = true;
            textBoxTotal.Enabled = true;
        }
    }
}
