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

namespace Locadora_de_motos_MotoRent.Frm
{



    public partial class FrmMotos : Form
    {
        public FrmMotos()
        {
            InitializeComponent();
        }

        private void FrmMotos_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarMotos();
        }

        private void ListarMotos()
        {
            List<string> motos = new List<string>()
    {
                "Honda CB 500",
                "Yamaha MT-07",
                "Kawasaki Ninja 400",
                "BMW S1000RR"
    };

            dgvMotos.DataSource = motos;


        }

        private async Task btnExcluir_Click(object sender, EventArgs e)
        {

            string nomeMotos = dgvMotos.SelectedRows[0].Cells[1].Value.ToString();

            var retorno = MessageBox.Show($"Tem certeza que deseja excluir o funcionario {nomeMotos}?", "Exclusão funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                int idMotos = (int)dgvMotos.SelectedRows[0].Cells[0].Value;

                await MotosRepository.Deletar(idMotos);

                MessageBox.Show($"O funcionário {nomeMotos} foi deletado com sucesso!",
                    "Exclusão funcionário",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                this.AtualizarTabela();
            }
        }

        private void AtualizarTabela()
        {

        }

        private void Deletar(object idMotos)
        {
            throw new NotImplementedException();
        }


        public class Moto
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }
            public double Preco { get; set; }

            
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto()
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Ano = int.Parse(txtAno.Text),
                Preco = double.Parse(txtPreco.Text)
            };

            // Exemplo: adicionando a uma lista em memória
            listaMotos.Add(moto);

            MessageBox.Show("Moto cadastrada com sucesso!");

            // Limpar campos
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtPreco.Clear();

            txtMarca.Focus();
        }
    }
}

