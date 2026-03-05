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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();

            Load += FrmFuncionarios_Load;
        }

        public async void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            await AtualizarTabela();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = dgvFuncionarios.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o funcionário {nomeFuncionario}?", "Exclusão Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                int idFuncinarios = (int)dgvFuncionarios.SelectedRows[0].Cells[0].Value;

                await FuncionariosRepository.Deletar(idFuncinarios);

                MessageBox.Show($" {nomeFuncionario} !",
                    "Exclusão ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                this.AtualizarTabela();
            }
        }

        public async Task AtualizarTabela()
        {
            var funcionario = await FuncionariosRepository.ObterTodos();

            dgvFuncionarios.DataSource = new BindingList<Funcionario>(funcionario.ToList());
        }

      
    }
}
