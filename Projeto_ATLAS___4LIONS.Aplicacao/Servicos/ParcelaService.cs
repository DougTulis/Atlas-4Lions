using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

public class ParcelaService : IParcelaService
{
    public void GerarParcelas(PendenciaFinanceira pendenciaFinanceira, int quantidadeParcelas)
    {
 
        decimal valorParcela = pendenciaFinanceira.ValorTotal / quantidadeParcelas;
        DateTime dataVencimento = DateTime.Now.AddMonths(1);

        for (int i = 1; i <= quantidadeParcelas; i++)
        {
            var parcela = Parcela.Create(i, dataVencimento, valorParcela);
            pendenciaFinanceira.AdicionarParcela(parcela);

            dataVencimento = dataVencimento.AddMonths(1); 

        }
    }
}
