using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

public class ParcelaService : IParcelaService
{
    public void GerarParcelas(PendenciaFinanceira pendenciaFinanceira, int quantidadeParcelas)
    {
 
        decimal valorParcela = pendenciaFinanceira.ValorTotal / quantidadeParcelas;
        // vou implementar aquela logica da ultima parcela pois nem todas as parcelas vao ter os valores devidamente equivalentes dependendo da qnt de parcelas.
        DateTime dataVencimento = DateTime.Now.AddMonths(1);

        for (int i = 1; i <= quantidadeParcelas; i++)
        {
            var parcela = Parcela.Create(i, dataVencimento, valorParcela, pendenciaFinanceira);
            pendenciaFinanceira.AdicionarParcela(parcela);
            dataVencimento = dataVencimento.AddMonths(1); 
        }
    }
}
