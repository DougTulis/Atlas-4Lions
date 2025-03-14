using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;


public class ListarHistoricoLocacaoUseCase : IListarHistoricoLocacaoUseCase
{
    private readonly ILocacaoRepositorio _locacaoRepositorio;
    private readonly IPessoaRepositorio _pessoaRepositorio;
    private readonly IPendenciaFinanceiraRepositorio _pendenciaFinanceiraRepositorio;

    public ListarHistoricoLocacaoUseCase(ILocacaoRepositorio locacaoRepositorio, IPessoaRepositorio pessoaRepositorio, IPendenciaFinanceiraRepositorio pendenciaFinanceiraRepositorio)
    {
        _locacaoRepositorio = locacaoRepositorio;
        _pessoaRepositorio = pessoaRepositorio;
        _pendenciaFinanceiraRepositorio = pendenciaFinanceiraRepositorio;
    }

    public List<HistoricoLocacaoDTO> Executar()
    {
        var historico = new List<HistoricoLocacaoDTO>();

        try
        {
            var locacoes = _locacaoRepositorio.ListarTodas();

            foreach (var locacao in locacoes)
            {
                var locatario = _pessoaRepositorio.RecuperarPorId(locacao.IdLocatario);
                var condutor = _pessoaRepositorio.RecuperarPorId(locacao.IdCondutor);
                var pendencia = _pendenciaFinanceiraRepositorio.RecuperarPorId(locacao.IdPendenciaFinanceira);

             historico.Add(new HistoricoLocacaoDTO
             {
                 Id = locacao.Id,
                 DataCriacao = locacao.DataCriacao,
                 Saida = locacao.Saida,
                 Retorno = locacao.Retorno,
                 NomeCondutor = condutor.Nome,
                 Status = locacao.Status,
                 NomeLocatario = locatario.Nome,
                 TipoLocacao = locacao.TipoLocacao,
                 ValorTotal = locacao.ValorTotal,
             });
            }
        }
        catch (MySqlException ex)
        {
            throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
        }
        return historico;
    }
}
