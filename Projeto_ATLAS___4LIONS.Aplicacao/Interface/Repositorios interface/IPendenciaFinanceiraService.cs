using Projeto_ATLAS___4LIONS.Aplicacao.DTO;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IPendenciaFinanceiraService
    {
        void CriarPendenciaFinanceira(int idLocacao, int idPreco, int numeroParcelas);

        void CriarParcelas(int idPendencia, decimal valorTotal, int numeroParcelas);

    }
}
