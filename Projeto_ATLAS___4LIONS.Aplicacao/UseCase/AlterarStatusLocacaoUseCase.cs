
using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AlterarStatusLocacaoUseCase : IAlterarStatusLocacaoUseCase
    {

        private readonly ILocacaoRepositorio locacaoRepositorio;
        public AlterarStatusLocacaoUseCase(ILocacaoRepositorio locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }
        public RespostaPadrao<string> Executar(Guid locacaoId, EStatusLocacao novoStatus)
        {
            try
            {
                locacaoRepositorio.AtualizarStatusLocacao(locacaoId, novoStatus);
                return RespostaPadrao<string>.Sucesso(true, "Ok");
            }

            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}