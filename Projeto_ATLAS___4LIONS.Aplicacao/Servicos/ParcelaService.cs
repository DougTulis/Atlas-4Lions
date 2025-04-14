using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

public class ParcelaService : IParcelaService
{
    private readonly IParcelaRepositorio _parcelaRepositorio;

    public ParcelaService(IParcelaRepositorio parcelaRepositorio)
    {
        _parcelaRepositorio = parcelaRepositorio;
    }

    public void GerarParcelas(PendenciaFinanceira pendenciaFinanceira, int quantidadeParcelas)
    {
        decimal valorBaseParcela = Math.Round(pendenciaFinanceira.ValorTotal / quantidadeParcelas, 2);
        decimal valorRestante = pendenciaFinanceira.ValorTotal - (valorBaseParcela * (quantidadeParcelas - 1));

        DateTime dataVencimento = DateTime.Now.AddMonths(1);


        for (int i = 1; i <= quantidadeParcelas; i++)
        {
            decimal valorParcela = (i == quantidadeParcelas) ? valorRestante : valorBaseParcela;

            var parcela = Parcela.Create(i, dataVencimento, valorParcela, pendenciaFinanceira.Id);
            pendenciaFinanceira.AdicionarParcela(parcela);
            dataVencimento = dataVencimento.AddMonths(1);
            _parcelaRepositorio.Adicionar(parcela);

        }
    }
}
