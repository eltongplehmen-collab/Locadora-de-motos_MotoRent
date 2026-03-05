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
using System.Drawing.Text;

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






        public async Task AtualizarTabela()
        {
            var motos = await MotosRepository.ObterTodas();

            dgvMotos.DataSource = new BindingList<Moto>(motos.ToList());
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
        string.IsNullOrWhiteSpace(txtModelo.Text) ||
        string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }

            var moto = new Moto
            {

                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Ano = int.Parse(txtAno.Text),
                Placa = txtPlaca.Text,
                Categoria = txtCategoria.Text,
                ValorDiaria = decimal.Parse(txtValorDiaria.Text),
                Status = "Disponível"
            };

            try
            {
                await MotosRepository.Cadastrar(moto);
                MessageBox.Show("Moto cadastrada com sucesso!");

                // Limpar campos
                txtMarca.Clear();
                txtModelo.Clear();
                txtAno.Clear();
                txtPlaca.Clear();
                txtCategoria.Clear();
                txtValorDiaria.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private async void btnRevisar_Click(object sender, EventArgs e)
        {
            if (dgvMotos.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma moto!");
                return;
            }

            int id = Convert.ToInt32(dgvMotos.CurrentRow.Cells["Id"].Value);

            try
            {
                await MotosRepository.ColocarEmRevisao(id);

                MessageBox.Show("Moto enviada para revisão com sucesso!");

                // Se você tiver método de carregar motos
                // await CarregarMotos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private async Task CarregarMotos()
        {
            var motos = await MotosRepository.ListarTodas();
            dgvMotos.DataSource = motos.ToList();
        }

        private async void btnAtualizacao_Click(object sender, EventArgs e)
        {
            try
            {
                await CarregarMotos();
                MessageBox.Show("Lista atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMotos.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma moto para excluir!");
                return;
            }

            int id = Convert.ToInt32(dgvMotos.CurrentRow.Cells["Id"].Value);

            var confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir essa moto?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No)
                return;

            try
            {
                await MotosRepository.Excluir(id);

                MessageBox.Show("Moto excluída com sucesso!");

                await CarregarMotos(); // Atualiza o grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }

        }
    }
}

