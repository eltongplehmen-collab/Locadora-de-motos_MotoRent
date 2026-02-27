using Locadora_de_motos_MotoRent.Frm;

namespace Locadora_de_motos_MotoRent
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            var FrmtelaLoginAdminstrador = new FrmTelaLoginAdministrador();
            this.Hide();
            FrmtelaLoginAdminstrador.ShowDialog();
            this.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e, FrmTelaLoginUsuario frmTelaLoginUsuario)
        {
            var FrmtelaLogin = new FrmTelaLoginUsuario();
            this.Hide();
            frmTelaLoginUsuario.ShowDialog();
            this.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmTelaLoginUsuario = new FrmTelaLoginUsuario();
            this.Hide();
            frmTelaLoginUsuario.ShowDialog();
            this.Show();
        }
    }
}
