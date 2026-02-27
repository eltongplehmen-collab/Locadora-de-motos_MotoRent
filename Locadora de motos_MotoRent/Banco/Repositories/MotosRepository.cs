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

        internal static void Deletar(object idMotos)
        {
            throw new NotImplementedException();
        }
    }
}