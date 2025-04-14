using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class DevolverAutomovelEncerrarlLocUseCase : IDevolverAutomovelEncerrarLocUseCase
    {

        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ILocacaoRepositorio _locacaoRepositorio;

        public DevolverAutomovelEncerrarlLocUseCase(IAutomovelRepositorio automovelRepositorio, ILocacaoRepositorio locacaoRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
            _locacaoRepositorio = locacaoRepositorio;
        }

        public RespostaPadrao<string> ExecutarDevolucaoAutomovel(Guid automovelId,Guid locacaoId)
        {
           try
            {
                _automovelRepositorio.AtualizarStatus(automovelId, EStatusVeiculo.GARAGEM);
                _locacaoRepositorio.AtualizarStatusLocacao(locacaoId, EStatusLocacao.FINALIZADA);
                return RespostaPadrao<string>.Sucesso(true, "Devolução de automóvel", "Devolução realizada com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }


    }
}
