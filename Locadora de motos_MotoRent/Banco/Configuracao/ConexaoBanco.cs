using System.Data;
using System.Data.SqlClient;

namespace Locadora_de_motos_MotoRent.Banco.Configuração
{
    public class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database= locadora_motos; Trusted_Connection=True;");
        }

         

       
    }
}
