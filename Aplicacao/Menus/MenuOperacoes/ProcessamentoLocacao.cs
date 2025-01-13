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
            var useCaseListarStatusAndamento = new ListarLocacoesUseCase(locacaoRepositorio);
            var useCaseAtualizarStatus = new AlterarStatusLocacaoUseCase(locacaoRepositorio);
            Console.Write("Locações em andamento: ");
            useCaseListarStatusAndamento.ExecutarRecuperacaoStatusAndamento();

            Console.Write("\nDigite o ID da locação para confirmar ou 0 para voltar: ");
            int escolhaLocacao = int.Parse(Console.ReadLine());
            if (escolhaLocacao == 0) return;

            useCaseAtualizarStatus.Executar(escolhaLocacao, Dominio.ValueObjects.Enums.EStatusLocacao.FINALIZADO);

            Console.WriteLine("Status atualizado com sucesso!");
        }
    }
}
