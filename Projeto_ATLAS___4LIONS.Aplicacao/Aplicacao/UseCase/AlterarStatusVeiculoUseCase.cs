using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;


namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AlterarStatusVeiculoUseCase
    {
        private readonly IAutomovelRepositorio automovelRepositorio;
        public AlterarStatusVeiculoUseCase(IAutomovelRepositorio automovelRepositorio)
        {
            this.automovelRepositorio = automovelRepositorio;
        }
        public void Executar(int automovelId, EStatusVeiculo novoStatus)
        {
            try
            {
                automovelRepositorio.AtualizarStatus(automovelId, novoStatus);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

