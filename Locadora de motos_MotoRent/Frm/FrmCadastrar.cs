using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora_de_motos_MotoRent.Banco.Modelo;
using Locadora_de_motos_MotoRent.Banco.Repositories;
using Locadora_de_motos_MotoRent.Util;


namespace Locadora_de_motos_MotoRent.Frm
{
    public partial class FrmCadastrar : Form
    {

        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
     string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }

            var cliente = new Cliente
            {

                Nome = txtNome.Text,
                CPF = txtCPF.Text,
                Telefone = txtTelefone.Text,
                CNH = txtCNH.Text
            };

            try
            {
                await ClientesRepository.Cadastrar(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");

                // Limpar campos
                txtNome.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtCNH.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private async void btnRevisar_Click(object sender, EventArgs e)
        {
            if (dgvRevisar.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma moto!");
                return;
            }

            int id = Convert.ToInt32(dgvRevisar.CurrentRow.Cells["Id"].Value);

            try
            {
                await MotosRepository.ColocarEmRevisao(id);
                MessageBox.Show("Moto enviada para revisão com sucesso!");

                // Atualizar grid se tiver método de listar
                // CarregarMotos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
