using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class RegistroPagamento
    {

        private readonly IPendenciaFinanceiraRepositorio _pendFinRepositorio;
        private readonly IParcelaRepositorio _parcelaRepositorio;

        public RegistroPagamento(IPendenciaFinanceiraRepositorio pendFinRepositorio, IParcelaRepositorio parcelaRepositorio)
        {
            _pendFinRepositorio = pendFinRepositorio;
            _parcelaRepositorio = parcelaRepositorio;
        }

        public void Exibir()
        {
            var useCaseListarPendFin = new ListarPendenciaFinanceiraUseCase(_pendFinRepositorio);
            var useCaseListarParcelarPorPendFin = new ListarParcelaPorPendFinUseCase(_parcelaRepositorio);
            useCaseListarPendFin.Executar();
            Console.Write("\nDigite o ID da Pendência ou 0 para voltar: ");
            int escolhaPendencia = int.Parse(Console.ReadLine());
            if (escolhaPendencia == 0) return;
            var pendFin = useCaseListarPendFin.ExecutarRecuperarPorId(escolhaPendencia);
            useCaseListarParcelarPorPendFin.Executar(escolhaPendencia);

            Console.Write("\nDigite o número da sequência da parcela que deseja dar baixa ou 0 para voltar: ");
            int escolhaSequencia = int.Parse(Console.ReadLine());
            if (escolhaSequencia == 0) return;

            var parcela = _parcelaRepositorio.ListarPorPendFin(escolhaPendencia)
                .FirstOrDefault(p => p.Sequencia == escolhaSequencia);

            if (parcela == null)
            {
                Console.WriteLine("Parcela não encontrada");
                Console.Write("\nPressione qualquer tecla para voltar.");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite o valor pago: ");
            parcela.ValorPago = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a data do pagamento (dd/MM/yyyy): ");
            parcela.DataPagamento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe a espécie do pagamento (Ex: Dinheiro, Cartão): ");
            parcela.EspeciePagamento = Enum.Parse<EEspecie>(Console.ReadLine(), true);

            _parcelaRepositorio.Atualizar(parcela);

            Console.WriteLine("\nBaixa realizada com sucesso!");

            Console.Write("\nPressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
    }

}
