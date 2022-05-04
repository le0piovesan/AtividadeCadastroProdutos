
namespace ControleEstoque
{
    partial class FrmSaida
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.escolherSaida = new System.Windows.Forms.Button();
            this.dataGridViewSaida = new System.Windows.Forms.DataGridView();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxUnitario = new System.Windows.Forms.TextBox();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxidProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQteVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(327, 196);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(311, 22);
            this.textBoxNomeProduto.TabIndex = 28;
            // 
            // escolherSaida
            // 
            this.escolherSaida.Location = new System.Drawing.Point(234, 195);
            this.escolherSaida.Name = "escolherSaida";
            this.escolherSaida.Size = new System.Drawing.Size(75, 23);
            this.escolherSaida.TabIndex = 27;
            this.escolherSaida.Text = "...";
            this.escolherSaida.UseVisualStyleBackColor = true;
            this.escolherSaida.Click += new System.EventHandler(this.escolherSaida_Click_1);
            this.escolherSaida.Leave += new System.EventHandler(this.escolherSaida_Leave);
            // 
            // dataGridViewSaida
            // 
            this.dataGridViewSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaida.Location = new System.Drawing.Point(16, 362);
            this.dataGridViewSaida.Name = "dataGridViewSaida";
            this.dataGridViewSaida.RowHeadersWidth = 51;
            this.dataGridViewSaida.RowTemplate.Height = 24;
            this.dataGridViewSaida.Size = new System.Drawing.Size(848, 309);
            this.dataGridViewSaida.TabIndex = 26;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(317, 284);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotal.TabIndex = 25;
            // 
            // textBoxUnitario
            // 
            this.textBoxUnitario.Location = new System.Drawing.Point(117, 284);
            this.textBoxUnitario.Name = "textBoxUnitario";
            this.textBoxUnitario.Size = new System.Drawing.Size(100, 22);
            this.textBoxUnitario.TabIndex = 24;
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Location = new System.Drawing.Point(117, 244);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(100, 22);
            this.textBoxEstoque.TabIndex = 23;
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(117, 196);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(100, 22);
            this.textBoxProduto.TabIndex = 22;
            // 
            // textBoxidProduto
            // 
            this.textBoxidProduto.Location = new System.Drawing.Point(117, 157);
            this.textBoxidProduto.Name = "textBoxidProduto";
            this.textBoxidProduto.Size = new System.Drawing.Size(100, 22);
            this.textBoxidProduto.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Últimas Saídas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor Unitário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // textBoxQteVenda
            // 
            this.textBoxQteVenda.Location = new System.Drawing.Point(384, 244);
            this.textBoxQteVenda.Name = "textBoxQteVenda";
            this.textBoxQteVenda.Size = new System.Drawing.Size(100, 22);
            this.textBoxQteVenda.TabIndex = 30;
            this.textBoxQteVenda.TextChanged += new System.EventHandler(this.textBoxQteVenda_TextChanged);
            this.textBoxQteVenda.Leave += new System.EventHandler(this.textBoxQuantidadeDesej_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Quantidade Desejada";
            // 
            // FrmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 691);
            this.Controls.Add(this.textBoxQteVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.escolherSaida);
            this.Controls.Add(this.dataGridViewSaida);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxUnitario);
            this.Controls.Add(this.textBoxEstoque);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.textBoxidProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FrmSaida";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBoxidProduto, 0);
            this.Controls.SetChildIndex(this.textBoxProduto, 0);
            this.Controls.SetChildIndex(this.textBoxEstoque, 0);
            this.Controls.SetChildIndex(this.textBoxUnitario, 0);
            this.Controls.SetChildIndex(this.textBoxTotal, 0);
            this.Controls.SetChildIndex(this.dataGridViewSaida, 0);
            this.Controls.SetChildIndex(this.escolherSaida, 0);
            this.Controls.SetChildIndex(this.textBoxNomeProduto, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.textBoxQteVenda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Button escolherSaida;
        private System.Windows.Forms.DataGridView dataGridViewSaida;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxUnitario;
        private System.Windows.Forms.TextBox textBoxEstoque;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxidProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQteVenda;
        private System.Windows.Forms.Label label11;
    }
}
