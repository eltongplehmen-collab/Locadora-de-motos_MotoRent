using System.Security.Policy;

namespace Locadora_de_motos_MotoRent.Modelo
{
    public class Moto 
    {
        public int Id { get; set; }

        public string Marca { get; set; } = string.Empty;

        public string Modelo { get; set; } = string.Empty;

        public int Ano { get; set; }

        public string Placa { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public decimal ValorDiaria { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }

}

