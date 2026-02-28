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
    public partial class FrmTelaPrincipalUsuario : Form
    {

        private bool _logado;
        private int _idUsuario;

        public FrmTelaPrincipalUsuario(bool logado, int idUsuario)
        {
            InitializeComponent();
            _logado = logado;
            _idUsuario = idUsuario;
        }

        public FrmTelaPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FrmDevolução tela = new FrmDevolução();
            tela.Show();
        }

        private void btnMotos_Click(object sender, EventArgs e)
        {
            FrmMotos tela = new FrmMotos();
            tela.Show();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            FrmCadastros tela = new FrmCadastros();
            tela.Show();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            FrmAlugar tela = new FrmAlugar();
            tela.Show();
        }
    }
}
