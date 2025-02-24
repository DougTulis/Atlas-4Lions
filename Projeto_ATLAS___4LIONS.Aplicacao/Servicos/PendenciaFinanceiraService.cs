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

    public PendenciaFinanceira CriarPendencia(decimal valorTotal, ETipoLocacao tipoLocacao)
    {
        var pendenciaFinanceira = PendenciaFinanceira.Create(valorTotal);
        int quantidadeParcelas = tipoLocacao == ETipoLocacao.CONTRATO ? 3 : 1;

        _parcelaService.GerarParcelas(pendenciaFinanceira, quantidadeParcelas);

        return pendenciaFinanceira;
    }
}
