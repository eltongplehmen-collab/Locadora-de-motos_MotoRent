using System.Security.Policy;

namespace Locadora_de_motos_MotoRent.Modelo
{
    public class Moto 
    {
        public int Id { get; set; }

       public string Email { get; set; }

        public decimal Salario { get; set; }

        public char Sexo { get; set; }

        public string TipoContrato { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        
    }
}
