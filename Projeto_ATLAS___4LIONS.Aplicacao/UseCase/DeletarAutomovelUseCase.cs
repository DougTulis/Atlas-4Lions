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
        private readonly ITabelaPrecoRepositorio _precoRepositorio;
        public DeletarAutomovelUseCase(IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio precoRepsoitorio)
        {
            _automovelRepositorio = automovelRepositorio;
            _precoRepositorio = precoRepsoitorio;
        }
        public RespostaPadrao<string> Executar(AutomovelDTO automovelDto)
        {
            try
            {
                _automovelRepositorio.Deletar(automovelDto);
                return RespostaPadrao<string>.Sucesso(true, "Automóvel excluído com sucesso!");
            }

            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
