using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPendenciaFinanceiraUseCase : ICadastrarPendenciaFinanceiraUseCase
    {
        private readonly IPendenciaFinanceiraRepositorio _pendenciaRepositorio;
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _precoRepositorio;

        public CadastrarPendenciaFinanceiraUseCase(IPendenciaFinanceiraRepositorio pendenciaRepositorio, ILocacaoRepositorio locacaoRepositorio, IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio precoRepositorio)
        {
            _pendenciaRepositorio = pendenciaRepositorio;
            _locacaoRepositorio = locacaoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _precoRepositorio = precoRepositorio;
        }

        public void Executar(PendenciaFinanceiraDTO pendenciaDto)
        {
            try
            {
               // var pendenciaFinanceira = PendenciaFinanceira.Create(pendenciaDto.ValorTotal);
             
             //   if (!pendenciaFinanceira.Validacao())
                {
                    return;
               }
             //   _pendenciaRepositorio.Adicionar(pendenciaFinanceira);
               
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
