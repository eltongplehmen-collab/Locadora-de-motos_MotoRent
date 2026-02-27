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
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal(bool v, int v1)
        {
            InitializeComponent();
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMotos_Click(object sender, EventArgs e)

        {
            FrmMotos tela = new FrmMotos();
            tela.Show();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.Show();
        }
        
        
          
        
    }
    }


    


