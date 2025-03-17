using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarAutomovelUseCase : IListarAutomovelUseCase
    {

        private readonly IAutomovelRepositorio automovelRepositorio;

        public ListarAutomovelUseCase(IAutomovelRepositorio automovelRepositorio)
        {

            this.automovelRepositorio = automovelRepositorio;
        }

        public IEnumerable<AutomovelDTO> Executar()
        {
            try
            {
                var listaAutomoveis = automovelRepositorio.ListarTodos();
                var listaAutomoveisDto = listaAutomoveis.Select(x => new AutomovelDTO(x.Id,x.Modelo, x.Placa, x.Cor, x.Status, x.Ano, x.Chassi, x.Renavam, x.Oleokm, x.PastilhaFreioKm, x.IdPreco));
                return listaAutomoveisDto;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public AutomovelDTO? ExecutarRecuperarPorId(Guid id)
        {
            try
            {
                var automovelFiltrado = automovelRepositorio.RecuperarPorId(id);
                var automovelFiltradoDto = new AutomovelDTO(automovelFiltrado.Id,automovelFiltrado.Modelo, automovelFiltrado.Placa, automovelFiltrado.Cor, automovelFiltrado.Status, automovelFiltrado.Ano, automovelFiltrado.Chassi, automovelFiltrado.Renavam, automovelFiltrado.Oleokm, automovelFiltrado.PastilhaFreioKm, automovelFiltrado.IdPreco);

                return automovelFiltradoDto;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);

            }
        }


        public IEnumerable<AutomovelDTO> ExecutarStatusGaragem()
        {
            try
            {
                var listaAutomoveisGaragem = automovelRepositorio.ListarStatusGaragem();
                var listaAutomoveisGaragemDto = listaAutomoveisGaragem.Select(x => new AutomovelDTO(x.Id,x.Modelo, x.Placa, x.Cor, x.Status, x.Ano, x.Chassi, x.Renavam, x.Oleokm, x.PastilhaFreioKm, x.IdPreco));
                return listaAutomoveisGaragemDto;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);

            }

        }
    }
}
