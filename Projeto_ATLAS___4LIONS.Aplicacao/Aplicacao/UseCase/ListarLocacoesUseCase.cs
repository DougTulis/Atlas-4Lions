using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarLocacoesUseCase : IListarLocacoesUseCase
    {

        private readonly ILocacaoRepositorio _locacaoRepositorio;
        public ListarLocacoesUseCase(ILocacaoRepositorio locacaoRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
        }

        public IEnumerable<LocacaoDTO> Executar()
        {
            return _locacaoRepositorio.ListarTodas();

        }
        public IEnumerable<LocacaoDTO> ExecutarRecuperacaoStatusAndamento()
        {
            return _locacaoRepositorio.ListarStatusAndamento();


        }
        public LocacaoDTO? ExecutarRecuperarPorId(int id)
        {
            return _locacaoRepositorio.RecuperarPorId(id);

        }
    }
}
