using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_de_motos_MotoRent.Frm
{
    public partial class FrmTelaLoginUsuario : Form
    {
        public FrmTelaLoginUsuario()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            {
                if (txtUsuario.Text == "Usuario" && txtSenha.Text == "1234")
                {
                    var FrmTelaPrincipal = new FrmTelaPrincipal(true, 0);
                    this.Hide();
                    FrmTelaPrincipal.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                        "Erro ao realizar login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}


