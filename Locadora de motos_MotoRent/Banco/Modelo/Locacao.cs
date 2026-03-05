using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_motos_MotoRent.Banco.Modelo
{
    public class Locacao
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int MotoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorTotal { get; set; }

        public decimal ValorDiaria { get; set; }
    }
}
