using System.Data.SqlClient;
using Dapper;
using Locadora_de_motos_MotoRent.Banco.Configuração;
using Locadora_de_motos_MotoRent.Banco.Modelo;
using Locadora_de_motos_MotoRent.Modelo;


namespace Locadora_de_motos_MotoRent.Banco.Repositories
{
    public class ClientesRepository
    {


        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Cliente>> ObterTodos()
        {
            using var conexao = conexaoBanco.CriarConexao();

            return await conexao.QueryAsync<Cliente>(
                @"SELECT 
                    Id,
                    Nome,
                    Cpf,
                    Telefone,
                    Cnh
                  FROM Clientes");
        }

        public static async Task<Cliente?> ObterPorId(int idCliente)
        {
            using var conexao = conexaoBanco.CriarConexao();

            return await conexao.QueryFirstOrDefaultAsync<Cliente>(
                @"SELECT 
                      Id,
                      Nome,
                      Cpf,
                      Telefone,
                      Cnh
                  FROM Clientes
                 WHERE Id = @Id",
                new { Id = idCliente });
        }

        public static async Task Adicionar(Cliente cliente)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"INSERT INTO Clientes 
                    (Nome, Cpf, Telefone, Cnh)
                  VALUES 
                    (@Nome, @Cpf, @Telefone, @Cnh)",
                cliente);
        }

        public static async Task Atualizar(Cliente cliente)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"UPDATE Clientes
                  SET 
                      Nome = @Nome,
                      Cpf = @Cpf,
                      Telefone = @Telefone,
                      Cnh = @Cnh
                  WHERE Id = @Id",
                cliente);
        }

        public static async Task Deletar(int idCliente)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"DELETE FROM Clientes
                  WHERE Id = @Id",
                new { Id = idCliente });
        }

        public static async Task<int> Cadastrar(Cliente cliente)
        {
            using var conexao = conexaoBanco.CriarConexao();
            var idGerado = await conexao.ExecuteScalarAsync<int>(
                @"INSERT INTO Clientes 
                    (Nome, Cpf, Telefone, Cnh)
                  VALUES 
                    (@Nome, @Cpf, @Telefone, @Cnh);
                  SELECT CAST(SCOPE_IDENTITY() AS INT);",
                cliente);
            return idGerado;
        }
        public static async Task<IEnumerable<Cliente>> ListarTodos()
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = "SELECT * FROM Clientes ORDER BY Id DESC";
                return await conexao.QueryAsync<Cliente>(sql);
            }
        }



    }

   
}