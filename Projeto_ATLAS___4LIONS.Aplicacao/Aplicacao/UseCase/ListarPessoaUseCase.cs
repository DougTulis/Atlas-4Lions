
using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPessoaUseCase : IListarPessoaUseCase
    {
        private readonly IPessoaRepositorio pessoaRepositorio;
        public ListarPessoaUseCase(IPessoaRepositorio pessoaRepositorio)
        {
            try
            {
                this.pessoaRepositorio = pessoaRepositorio;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public IEnumerable<PessoaDTO> ExecutarDadosCompletos()
        {
            try
            {
                return pessoaRepositorio.ListarTodos();
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
        public IEnumerable<PessoaDTO> ExecutarDadosBreves()
        {
            try
            {
                return pessoaRepositorio.ListarTodos();
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }
        public PessoaDTO? ExecutarRecuperarPorId(int id)
        {
            try
            {
                return pessoaRepositorio.RecuperarPorId(id);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
        public IEnumerable<PessoaDTO> ExecutarRecuperacaoSemCnh()
        {
            try
            {
                return pessoaRepositorio.ListarSemCNH();
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
