
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

        public IEnumerable<PessoaDTO> Executar()
        {
            try
            {
                var pessoaLista = pessoaRepositorio.ListarTodos();

                var PessoaDtoLista = pessoaLista.Select(pessoa => new PessoaDTO(pessoa.Id, pessoa.DataCriacao, pessoa.Nome, pessoa.Email, pessoa.Contato, pessoa.TipoPessoa, pessoa.NumeroDocumento, pessoa.DataRegistro, pessoa.NumeroCnh, pessoa.VencimentoCnh));

                return PessoaDtoLista;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public PessoaDTO? ExecutarRecuperarPorId(Guid id)
        {
            try
            {

                var pessoaFiltrada = pessoaRepositorio.RecuperarPorId(id);
                var pessoaFiltradaDto = new PessoaDTO(pessoaFiltrada.Id, pessoaFiltrada.DataCriacao, pessoaFiltrada.Nome, pessoaFiltrada.Email, pessoaFiltrada.Contato, pessoaFiltrada.TipoPessoa, pessoaFiltrada.NumeroDocumento, pessoaFiltrada.DataRegistro, pessoaFiltrada.NumeroCnh, pessoaFiltrada.VencimentoCnh);

                return pessoaFiltradaDto;
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
                var pessoaLista = pessoaRepositorio.ListarSemCNH();
                var PessoaDtoLista = pessoaLista.Select(pessoa => new PessoaDTO(pessoa.Id, pessoa.DataCriacao, pessoa.Nome, pessoa.Email, pessoa.Contato, pessoa.TipoPessoa, pessoa.NumeroDocumento, pessoa.DataRegistro, pessoa.NumeroCnh, pessoa.VencimentoCnh));

                return PessoaDtoLista;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
