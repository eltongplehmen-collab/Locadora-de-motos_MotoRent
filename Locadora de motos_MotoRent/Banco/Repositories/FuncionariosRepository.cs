using System.Data.SqlClient;
using Dapper;
using Locadora_de_motos_MotoRent.Banco.Configuração;
using Locadora_de_motos_MotoRent.Banco.Modelo;
using Locadora_de_motos_MotoRent.Modelo;
using Microsoft.VisualBasic.ApplicationServices;

namespace Locadora_de_motos_MotoRent.Banco.Repositories
{
    public class FuncionariosRepository
    {
        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Funcionario>> ObterTodos()
        {
            using var conexao = conexaoBanco.CriarConexao();

            return await conexao.QueryAsync<Funcionario>(
                @"SELECT 
                    Id,
                    Nome,
                    Cpf,
                    Telefone,
                    Email,
                    Cargo,
                    Salario,
                    DataAdmissao,
                    DataCadastro,
                    DataAtualizacao
                  FROM Funcionarios");
        }

        public static async Task<Funcionario?> ObterPorId(int idFuncionario)
        {
            using var conexao = conexaoBanco.CriarConexao();

            return await conexao.QueryFirstOrDefaultAsync<Funcionario>(
                @"SELECT 
                    Id,
                    Nome,
                    Cpf,
                    Telefone,
                    Email,
                    Cargo,
                    Salario,
                    DataAdmissao,
                    DataCadastro,
                    DataAtualizacao
                  FROM Funcionarios
                  WHERE Id = @Id",
                new { Id = idFuncionario });
        }

        public static async Task Adicionar(Funcionario funcionario)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"INSERT INTO Funcionarios
                    (Nome, Cpf, Telefone, Email, Cargo, Salario, DataAdmissao, DataCadastro, DataAtualizacao)
                  VALUES
                    (@Nome, @Cpf, @Telefone, @Email, @Cargo, @Salario, @DataAdmissao, @DataCadastro, @DataAtualizacao)",
                funcionario);
        }

        public static async Task Atualizar(Funcionario funcionario)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"UPDATE Funcionarios
                  SET
                    Nome = @Nome,
                    Cpf = @Cpf,
                    Telefone = @Telefone,
                    Email = @Email,
                    Cargo = @Cargo,
                    Salario = @Salario,
                    DataAdmissao = @DataAdmissao,
                    DataAtualizacao = @DataAtualizacao
                  WHERE Id = @Id",
                funcionario);
        }

        public static async Task Deletar(int idFuncionario)
        {
            using var conexao = conexaoBanco.CriarConexao();

            await conexao.ExecuteAsync(
                @"DELETE FROM Funcionarios
                  WHERE Id = @Id",
                new { Id = idFuncionario });
        }


        public static async Task<int> Cadastrar(Funcionario funcionario)
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = @"INSERT INTO Funcionarios
                               (Nome, Cpf, Cargo, Telefone, Salario, DataCadastro)
                               VALUES
                               (@Nome, @Cpf, @Cargo, @Telefone, @Salario, GETDATE())";

                return await conexao.ExecuteAsync(sql, funcionario);
            }


        }

        public static async Task<IEnumerable<Funcionario>> ListarTodos()
        {
            using (SqlConnection conexao = (SqlConnection)conexaoBanco.CriarConexao())
            {
                string sql = "SELECT * FROM Funcionarios ORDER BY Id DESC";
                return await conexao.QueryAsync<Funcionario>(sql);
            }
        }
    }
}