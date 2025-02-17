using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;


public class ListarHistoricoLocacaoUseCase
{
    private readonly ILocacaoRepositorio _locacaoRepositorio;
    private readonly IPessoaRepositorio _pessoaRepositorio;

    public ListarHistoricoLocacaoUseCase(ILocacaoRepositorio locacaoRepositorio, IPessoaRepositorio pessoaRepositorio)
    {
        _locacaoRepositorio = locacaoRepositorio;
        _pessoaRepositorio = pessoaRepositorio;
    }

    public List<HistoricoLocacaoDTO> Executar()
    {
        var locacoes = _locacaoRepositorio.ListarTodas();
        var historico = new List<HistoricoLocacaoDTO>();

        foreach (var locacao in locacoes)
        {
            var locatario = _pessoaRepositorio.RecuperarPorId(locacao.IdLocatario);
            var condutor = _pessoaRepositorio.RecuperarPorId(locacao.IdCondutor);

            historico.Add(new HistoricoLocacaoDTO
            {
                Id = locacao.Id,
                NomeLocatario = locatario.Nome,
                NomeCondutor = condutor.Nome,
                DataCriacao = locacao.DataCriacao,
                Saida = locacao.Saida,
                Retorno = locacao.Retorno,
                TipoLocacao = locacao.TipoLocacao,
                ValorTotal = locacao.ValorTotal,
                Status = locacao.Status
            });
        }

        return historico;
    }
}
