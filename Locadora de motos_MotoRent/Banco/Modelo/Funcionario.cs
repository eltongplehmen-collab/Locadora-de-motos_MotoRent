using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_motos_MotoRent.Banco.Modelo
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string CNH { get; set; }

        public string Cargo { get; set; }

        public decimal Salario { get; set; }

        public DateTime DataAdmissao { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
