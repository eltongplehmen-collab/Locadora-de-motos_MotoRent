using System.ComponentModel;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Dapper;
using Locadora_de_motos_MotoRent.Banco.Configuração;
using Locadora_de_motos_MotoRent.Modelo;

namespace Locadora_de_motos_MotoRent.Banco.Repositories
{
    public class MotosRepository
    {
        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Moto>> ObterTodas()
        {
            using var conexao = conexaoBanco.CriarConexao();

            return await conexao.QueryAsync<Moto>(
                @"SELECT 
                    Id,
                    Marca,
                    Modelo,
                    Ano,
                    Placa,
                    Categoria,
                    ValorDiaria,
                    Status,
                    DataCadastro,
                    DataAtualizacao
                  FROM Motos");
        }

        public static async Task<Moto?> ObterPorId(int idMoto)
        {
            using var conexao = conexaoBanco.CriarConexao();

            return await conexao.QueryFirstOrDefaultAsync<Moto>(
               @"SELECT 
                      Id,
                      Marca,
                      Modelo,
                      Ano,
                      Placa,
                      Categoria,
                      ValorDiaria,
                      Status,
                      DataCadastro,
                      DataAtualizacao
                      FROM Motos
                     WHERE Id = @Id",
                new { Id = idMoto });   
        }

        public static async Task Adicionar(Moto moto)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"INSERT INTO Motos 
                    (Marca, Modelo, Ano, Placa, Categoria, ValorDiaria, Status, DataCadastro, DataAtualizacao)
                  VALUES 
                    (@Marca, @Modelo, @Ano, @Placa, @Categoria, @ValorDiaria, @Status, @DataCadastro, @DataAtualizacao)",
                moto);
        }

        public static async Task Atualizar(Moto moto)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"UPDATE Motos
                  SET 
                      Marca = @Marca,
                      Modelo = @Modelo,
                      Ano = @Ano,
                      Placa = @Placa,
                      Categoria = @Categoria,
                      ValorDiaria = @ValorDiaria,
                      Status = @Status,
                      DataAtualizacao = @DataAtualizacao
                  WHERE Id = @Id",
                moto);
        }

        public static async Task Deletar(int idMoto)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"DELETE FROM Motos
                  WHERE Id = @Id",  
                new { Id = idMoto });
        }

        public static async Task<int> ColocarEmRevisao(int id)
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = @"UPDATE Motos
                               SET Status = @Status,
                                   DataAtualizacao = GETDATE()
                               WHERE Id = @Id";

                return await conexao.ExecuteAsync(sql, new
                {
                    Id = id,
                    Status = "Em Revisão"
                });
            }
        }

        public static async Task<int> Cadastrar(Moto moto)
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = @"INSERT INTO Motos
                               (Marca, Modelo, Ano, Placa, Categoria, ValorDiaria, Status, DataCadastro, DataAtualizacao)
                               VALUES
                               (@Marca, @Modelo, @Ano, @Placa, @Categoria, @ValorDiaria, @Status, GETDATE(), GETDATE())";

                return await conexao.ExecuteAsync(sql, moto);
            }

        }

        public static async Task<IEnumerable<Moto>> ListarTodas()
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = "SELECT * FROM Motos ORDER BY Id DESC";
                return await conexao.QueryAsync<Moto>(sql);
            }
        }

        public static async Task<int> Excluir(int id)
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = "DELETE FROM Motos WHERE Id = @Id";
                return await conexao.ExecuteAsync(sql, new { Id = id });
            }
        }


        public static async Task<Moto> BuscarPorPlaca(string placa)
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = "SELECT * FROM Motos WHERE Placa = @Placa";
                return await conexao.QueryFirstOrDefaultAsync<Moto>(sql, new { Placa = placa });
            }
        }

        public static async Task<int> AtualizarStatus(int id, string status)
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = @"UPDATE Motos
                       SET Status = @Status,
                           DataAtualizacao = GETDATE()
                       WHERE Id = @Id";

                return await conexao.ExecuteAsync(sql, new { Id = id, Status = status });
            }
        }

        internal static async Task<Moto?> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}