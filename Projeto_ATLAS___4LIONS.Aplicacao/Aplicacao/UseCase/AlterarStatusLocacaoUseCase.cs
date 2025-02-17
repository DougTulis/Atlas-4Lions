
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AlterarStatusLocacaoUseCase
    {

        private readonly ILocacaoRepositorio locacaoRepositorio;
        public AlterarStatusLocacaoUseCase(ILocacaoRepositorio locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }
        public void Executar(int locacaoId, EStatusLocacao novoStatus)
        {
            try
            {
             //   locacaoRepositorio.AtualizarStatus(locacaoId, novoStatus);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}