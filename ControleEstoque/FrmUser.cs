using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmUser : ControleEstoque.FrmBase
    {
        
        public FrmUser()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ModelUser model = new ModelUser();
            List<DtoUserList> list = model.GetUsuarios();
            gridUsuarios.DataSource = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void LimparCampos()
        {
            textID.Text = String.Empty;
            textNome.Text = String.Empty;
            textLogin.Text = String.Empty;
            textSenha.Text = String.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModelUser model = new ModelUser();
            DtoUser u = new DtoUser();

            u.nome = textNome.Text;
            u.login = textLogin.Text;
            u.senha = textSenha.Text;

            if (textID.Text == String.Empty)
                model.SetUsuario(u);
            else
                u.id = int.Parse(textID.Text);
                model.EditarUsuario(u);

            LimparCampos();
            DesabilitarText();
            CarregarGrid();

        }

        private void DesabilitarText()
        {
            textNome.Enabled = false;
            textLogin.Enabled = false;
            textSenha.Enabled = false;
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
            textLogin.Enabled = true;
            textSenha.Enabled = true;
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

        private void gridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gridUsuarios.CurrentRow.Cells[0].Value;
            ModelUser model = new ModelUser();

            DtoUser usuario = model.GetUsuario(id);

            textID.Text = usuario.id.ToString();
            textNome.Text = usuario.nome;
            textLogin.Text = usuario.login;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ModelUser model = new ModelUser();
            if (textID.Text == String.Empty)
            {
                FrmAlert f = new FrmAlert();
                f.Show();
            }
            else
            {
                model.DeletarUsuario(int.Parse(textID.Text));
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
