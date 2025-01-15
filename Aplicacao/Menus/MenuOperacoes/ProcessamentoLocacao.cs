using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class ProcessamentoLocacao
    {

        public static void Exibir()
        {
            var locacaoRepositorio = new LocacaoRepositorio();
            var automovelRepositorio = new AutomovelRepositorio();
            var useCaseListarStatusAndamento = new ListarLocacoesUseCase(locacaoRepositorio);
            var useCaseRecuperarPorId = new ListarLocacoesUseCase(locacaoRepositorio);
            var useCaseAtualizarStatus = new AlterarStatusLocacaoUseCase(locacaoRepositorio);
            var alterarStatusAutomovel = new AlterarStatusVeiculoUseCase(automovelRepositorio);
            Console.Write("Locações em andamento: ");
            useCaseListarStatusAndamento.ExecutarRecuperacaoStatusAndamento();

            Console.Write("\nDigite o ID da locação para confirmar ou 0 para voltar: ");
            int escolhaLocacao = int.Parse(Console.ReadLine());
            if (escolhaLocacao == 0) return;
            var locacao = useCaseRecuperarPorId.ExecutarRecuperarPorId(escolhaLocacao);

            useCaseAtualizarStatus.Executar(escolhaLocacao, Dominio.ValueObjects.Enums.EStatusLocacao.FINALIZADO);
            alterarStatusAutomovel.Executar(locacao.Automovel.Id, Dominio.ValueObjects.Enums.EStatusVeiculo.GARAGEM);
        }
    }
}
