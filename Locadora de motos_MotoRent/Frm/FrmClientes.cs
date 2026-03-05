using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora_de_motos_MotoRent.Banco.Modelo;
using Locadora_de_motos_MotoRent.Banco.Repositories;
using Locadora_de_motos_MotoRent.Modelo;

namespace Locadora_de_motos_MotoRent.Frm
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();

            Load += FrmClientes_Load;


        }

        private async void FrmClientes_Load(object? sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        public async Task AtualizarTabela()
        {
            var cliente = await ClientesRepository.ObterTodos();

            dgvClientes.DataSource = new BindingList<Cliente>(cliente.ToList());

        }

        private async Task btnExcluir_ClickAsync(object sender, EventArgs e)
        {


            string nomeCliente = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();


            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o cliente {nomeCliente}?", "Exclusão Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (retorno == DialogResult.Yes)
            {
                int idCliente = (int)dgvClientes.SelectedRows[0].Cells[0].Value;


                await ClientesRepository.Deletar(idCliente);


                MessageBox.Show($"Cliente {nomeCliente} excluído com sucesso!",
                    "Exclusão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.AtualizarTabela();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


        }


    }
}


