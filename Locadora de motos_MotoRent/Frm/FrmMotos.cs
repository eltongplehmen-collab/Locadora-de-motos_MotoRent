using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora_de_motos_MotoRent.Banco.Repositories;
using Locadora_de_motos_MotoRent.Modelo;
using System.Collections.Generic;

namespace Locadora_de_motos_MotoRent.Frm
{



    public partial class FrmMotos : Form
    {
        public FrmMotos()
        {
            InitializeComponent();


            Load += FrmMotos_Load;


        }

        private async void FrmMotos_Load(object sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private async Task btnExcluir_Click(object sender, EventArgs e)
        {

            string nomeMotos = dgvMotos.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir a moto? {nomeMotos}?", "Exclusão Moto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                int idMotos = (int)dgvMotos.SelectedRows[0].Cells[0].Value;

                await MotosRepository.Deletar(idMotos);

                MessageBox.Show($" {nomeMotos} !",
                    "Exclusão ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                this.AtualizarTabela();
            }
        }

        public async Task AtualizarTabela()
        {
            var motos = await MotosRepository.ObterTodas();

            dgvMotos.DataSource = new BindingList<Moto>(motos.ToList());
        }

       
    }
}

