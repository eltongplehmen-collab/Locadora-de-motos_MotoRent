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

namespace Locadora_de_motos_MotoRent.Frm
{
    public partial class FrmCadastros : Form
    {
        public FrmCadastros()
        {
            InitializeComponent();

            Load += FrmCadastros_Load;
        }

        public async void FrmCadastros_Load(object sender, EventArgs e)
        {
            await AtualizarTabela();

           
            await CarregarClientes();
            await CarregarFuncionarios();
        
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task AtualizarTabela()
        {
            var cliente = await ClientesRepository.ObterTodos();
            dgvCadastros.DataSource = new BindingList<Cliente>(cliente.ToList());

            var funcionario = await FuncionariosRepository.ObterTodos();
            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionario.ToList());
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                await CarregarClientes();
                await CarregarFuncionarios();

                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private async Task CarregarClientes()
        {
            var clientes = await ClientesRepository.ListarTodos();
            dgvCadastros.DataSource = clientes.ToList();
        }

        private async Task CarregarFuncionarios()
        {
            var funcionarios = await FuncionariosRepository.ListarTodos();
            dgvFuncionarios.DataSource = funcionarios.ToList();
        }



    }
}
