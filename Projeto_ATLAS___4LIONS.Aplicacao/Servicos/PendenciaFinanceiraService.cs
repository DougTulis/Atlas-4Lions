using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

public class PendenciaFinanceiraService : IPendenciaFinanceiraService
{
    private readonly IParcelaService _parcelaService;

    public PendenciaFinanceiraService(IParcelaService parcelaService)
    {
        _parcelaService = parcelaService;
    }

    public PendenciaFinanceira CriarPendencia(decimal valorTotal)
    {
        var pendenciaFinanceira = PendenciaFinanceira.Create(valorTotal,quantidadeParcelas);

         return pendenciaFinanceira;
    }
}
