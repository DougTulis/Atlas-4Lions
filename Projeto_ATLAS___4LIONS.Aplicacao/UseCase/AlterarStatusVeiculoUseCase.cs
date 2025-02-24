using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
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
        public void Executar(Guid automovelId, EStatusVeiculo novoStatus)
        {
            try
            {
                _automovelRepositorio.AtualizarStatus(automovelId, novoStatus);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}

