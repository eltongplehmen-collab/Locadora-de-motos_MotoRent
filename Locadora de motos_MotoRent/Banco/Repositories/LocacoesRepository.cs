using Dapper;
using Locadora_de_motos_MotoRent.Banco.Configuração;
using Locadora_de_motos_MotoRent.Banco.Modelo;
using System.Data.SqlClient;

public class LocacoesRepository
{
    private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

    public static async Task<Locacao> BuscarLocacaoAtiva(int motoId)
    {
        using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
        {
            string sql = @"SELECT * FROM Locacoes 
                       WHERE MotoId = @MotoId 
                       AND DataDevolucao IS NULL";

            return await conexao.QueryFirstOrDefaultAsync<Locacao>(sql, new { MotoId = motoId });
        }
    }

        public static async Task Inserir(Locacao locacao)
    {
        using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
        {
            string sql = @"INSERT INTO Locacoes
                       (MotoId, ClienteId, FuncionarioId,
                        DataInicio, DataFim,
                        ValorDiaria, ValorTotal, Status)
                       VALUES
                       (@MotoId, @ClienteId, @FuncionarioId,
                        @DataInicio, @DataFim,
                        @ValorDiaria, @ValorTotal, 'Ativa')";

            await conexao.ExecuteAsync(sql, locacao);
        }
    }
}
