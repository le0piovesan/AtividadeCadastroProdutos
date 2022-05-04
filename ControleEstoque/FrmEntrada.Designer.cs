
namespace ControleEstoque
{
    partial class FrmEntrada
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxidProduto = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxUnitario = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewEntrada = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor Unitário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Valor Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Últimas Entradas:";
            // 
            // textBoxidProduto
            // 
            this.textBoxidProduto.Location = new System.Drawing.Point(112, 167);
            this.textBoxidProduto.Name = "textBoxidProduto";
            this.textBoxidProduto.Size = new System.Drawing.Size(100, 22);
            this.textBoxidProduto.TabIndex = 7;
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(112, 206);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(100, 22);
            this.textBoxProduto.TabIndex = 8;
            this.textBoxProduto.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(112, 254);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // textBoxUnitario
            // 
            this.textBoxUnitario.Location = new System.Drawing.Point(112, 294);
            this.textBoxUnitario.Name = "textBoxUnitario";
            this.textBoxUnitario.Size = new System.Drawing.Size(100, 22);
            this.textBoxUnitario.TabIndex = 10;
            this.textBoxUnitario.Leave += new System.EventHandler(this.textBoxVlrUnitario_Leave);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(312, 294);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotal.TabIndex = 11;
            // 
            // dataGridViewEntrada
            // 
            this.dataGridViewEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrada.Location = new System.Drawing.Point(11, 372);
            this.dataGridViewEntrada.Name = "dataGridViewEntrada";
            this.dataGridViewEntrada.RowHeadersWidth = 51;
            this.dataGridViewEntrada.RowTemplate.Height = 24;
            this.dataGridViewEntrada.Size = new System.Drawing.Size(848, 309);
            this.dataGridViewEntrada.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(322, 206);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(311, 22);
            this.textBoxNomeProduto.TabIndex = 14;
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1017, 693);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEntrada);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxUnitario);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.textBoxidProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FrmEntrada";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBoxidProduto, 0);
            this.Controls.SetChildIndex(this.textBoxProduto, 0);
            this.Controls.SetChildIndex(this.textBoxQuantidade, 0);
            this.Controls.SetChildIndex(this.textBoxUnitario, 0);
            this.Controls.SetChildIndex(this.textBoxTotal, 0);
            this.Controls.SetChildIndex(this.dataGridViewEntrada, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.textBoxNomeProduto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxidProduto;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxUnitario;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridView dataGridViewEntrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
    }
}
