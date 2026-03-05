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
    public partial class FrmAlugar : Form
    {
        public FrmAlugar()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            {
                txtPlaca.Clear();
                txtClienteId.Clear();
                txtValorDiaria.Clear();
                lblStatus.Text = "";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();

            if (string.IsNullOrWhiteSpace(placa))
            {
                MessageBox.Show("Digite a placa!");
                return;
            }

            try
            {
                var moto = await MotosRepository.BuscarPorPlaca(placa);

                if (moto == null)
                {
                    MessageBox.Show("Moto não encontrada!");
                    return;
                }

                txtValorDiaria.Text = moto.ValorDiaria.ToString("F2");
                lblStatus.Text = moto.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar moto: " + ex.Message);
            }   
        }

        private async void btnAlugar_Click(object sender, EventArgs e)
        {
            var moto = await MotosRepository.BuscarPorPlaca(txtPlaca.Text);

            if (moto == null)
            {
                MessageBox.Show("Moto não encontrada!");
                return;
            }

            DateTime inicio = dtpInicio.Value;
            DateTime fim = dtpFim.Value;

            int dias = (fim - inicio).Days;

            if (dias <= 0)
            {
                MessageBox.Show("Data inválida!");
                return;
            }

            decimal valorTotal = dias * moto.ValorDiaria;

            Locacao novaLocacao = new Locacao
            {
                MotoId = moto.Id,
                ClienteId = int.Parse(txtClienteId.Text),
                Id = int.Parse(txtClienteId.Text),
                DataInicio = inicio,
                DataFim = fim,
                ValorDiaria = moto.ValorDiaria,
                ValorTotal = valorTotal
            };

            await LocacoesRepository.Inserir(novaLocacao);
            await MotosRepository.AtualizarStatus(moto.Id, "Alugada");

            MessageBox.Show("Moto alugada com sucesso!");

            LimparCampos();
        }

        private void LimparCampos()
        {
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox txt)
                        txt.Clear();
                }

                dtpInicio.Value = DateTime.Now;
                dtpFim.Value = DateTime.Now.AddDays(1);
            }
        }
    }
}
