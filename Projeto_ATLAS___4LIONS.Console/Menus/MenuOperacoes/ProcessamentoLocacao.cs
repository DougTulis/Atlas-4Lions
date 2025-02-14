using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class ProcessamentoLocacao
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;

        public ProcessamentoLocacao(ILocacaoRepositorio locacaoRepositorio, IAutomovelRepositorio automovelRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _automovelRepositorio = automovelRepositorio;
        }

        public void Exibir()
        {
   
            var useCaseListarStatusAndamento = new ListarLocacoesUseCase(_locacaoRepositorio);
            var useCaseRecuperarPorId = new ListarLocacoesUseCase(_locacaoRepositorio);
            var useCaseAtualizarStatus = new AlterarStatusLocacaoUseCase(_locacaoRepositorio);
            var alterarStatusAutomovel = new AlterarStatusVeiculoUseCase(_automovelRepositorio);

            Console.Write("Locações em andamento: ");
            useCaseListarStatusAndamento.ExecutarRecuperacaoStatusAndamento();

            Console.Write("\nDigite o ID da locação para confirmar ou 0 para voltar: ");
            int escolhaLocacao = int.Parse(Console.ReadLine());
            if (escolhaLocacao == 0) return;
            var locacao = useCaseRecuperarPorId.ExecutarRecuperarPorId(escolhaLocacao);

            useCaseAtualizarStatus.Executar(escolhaLocacao, Dominio.ValueObjects.Enums.EStatusLocacao.FINALIZADO);
            alterarStatusAutomovel.Executar(locacao.IdAutomovel, Dominio.ValueObjects.Enums.EStatusVeiculo.GARAGEM);
        }
    }
}
