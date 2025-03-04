using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;


namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AlterarStatusVeiculoUseCase : IAlterarStatusVeiculoUseCase
    {
        private readonly IAutomovelRepositorio _automovelRepositorio;
        public AlterarStatusVeiculoUseCase(IAutomovelRepositorio automovelRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
        }
        public RespostaPadrao<string> ExecutarParaGaragem(Guid automovelId)
        {
            try
            {
                _automovelRepositorio.AtualizarStatus(automovelId,EStatusVeiculo.GARAGEM);
                return RespostaPadrao<string>.Sucesso(true, "Ok");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
        public RespostaPadrao<string> ExecutarParaAlugado(Guid automovelId)
        {
            try
            {
                _automovelRepositorio.AtualizarStatus(automovelId, EStatusVeiculo.ALUGADO);
                return RespostaPadrao<string>.Sucesso(true, "Ok");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}

