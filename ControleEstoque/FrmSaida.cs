using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmSaida : ControleEstoque.FrmBase
    {
        public FrmSaida()
        {
            InitializeComponent();

            ModelProduct model = new ModelProduct();
            dataGridViewSaida.DataSource = model.ListProdutosSaida();

            textBoxidProduto.Enabled = false;
            textBoxEstoque.Enabled = false;
            textBoxUnitario.Enabled = false;
            textBoxTotal.Enabled = false;
            textBoxQteVenda.Enabled = false;

        }


        private void textBox2_Leave(object sender, EventArgs e)
        {
            ModelProduct get = new ModelProduct();
            DtoProduct produto = get.GetProduto(int.Parse(textBoxProduto.Text));
            textBoxNomeProduto.Text = produto.nome;
        }


        private void escolherSaida_Click_1(object sender, EventArgs e)
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

        private void escolherSaida_Leave(object sender, EventArgs e)
        {
            ModelProduct get = new ModelProduct();
            DtoProduct produto = get.GetProduto(int.Parse(textBoxProduto.Text));
            DtoEntrada entrada = get.GetEntrada(int.Parse(textBoxProduto.Text));

            textBoxidProduto.Text = produto.id.ToString();
            textBoxNomeProduto.Text = produto.nome;
            textBoxUnitario.Text = produto.unidade;
            textBoxEstoque.Text = entrada.qteproduto.ToString();
        }

        private void textBoxQuantidadeDesej_Leave(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(textBoxQteVenda.Text) * decimal.Parse(textBoxUnitario.Text);
            textBoxTotal.Text = total.ToString();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            textBoxQteVenda.Enabled = true;
        }

        private void textBoxQteVenda_TextChanged(object sender, EventArgs e)
        {
            //decimal total = decimal.Parse(textBoxQteVenda.Text) * decimal.Parse(textBoxUnitario.Text);
            //textBoxTotal.Text = total.ToString();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            ModelProduct model = new ModelProduct();
            DtoSaida saida = new DtoSaida();
            DtoEntrada entrada = model.GetEntrada(int.Parse(textBoxProduto.Text));

            saida.idproduto = int.Parse(textBoxidProduto.Text);
            saida.qtevenda = int.Parse(textBoxQteVenda.Text);
            saida.vlrcustoproduto = decimal.Parse(textBoxUnitario.Text);
            saida.vlrtotalvenda = decimal.Parse(textBoxTotal.Text);
            saida.dtvenda = DateTime.Now;

            entrada.qteproduto = int.Parse(textBoxEstoque.Text) - int.Parse(textBoxQteVenda.Text);

            model.SetSaidaProduto(saida);
            model.EditarEntradaVenda(entrada);

            textBoxidProduto.Text = "";
            textBoxEstoque.Text = "";
            textBoxUnitario.Text = "";
            textBoxTotal.Text = "";
            textBoxQteVenda.Text = "";

            dataGridViewSaida.DataSource = model.ListProdutosSaida();
        }
    }
}
