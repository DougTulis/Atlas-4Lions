using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class DeletarAutomovelUseCase : IDeletarAutomovelUseCase
    {
        private readonly IAutomovelRepositorio _automovelRepositorio;
        public DeletarAutomovelUseCase(IAutomovelRepositorio automovelRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
        }
        public RespostaPadrao<string> Executar(Guid id)
        {
            try
            {
                _automovelRepositorio.Deletar(id);
                return RespostaPadrao<string>.Sucesso(true, "Deleção de automóveis", "Automóvel excluído com sucesso!");
            }

            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
