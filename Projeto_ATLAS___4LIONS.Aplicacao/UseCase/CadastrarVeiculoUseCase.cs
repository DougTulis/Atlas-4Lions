using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarVeiculoUseCase : ICadastrarVeiculoUseCase
    {
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _precoRepositorio;
        public CadastrarVeiculoUseCase(IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio precoRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
            _precoRepositorio = precoRepositorio;
        }

        public RespostaPadrao<string> Executar(AutomovelDTO automovelDto)
        {
            try
            {
                var automovel = Automovel.Create(automovelDto.Modelo, automovelDto.Placa, automovelDto.Cor, automovelDto.Status, automovelDto.Ano, automovelDto.Chassi, automovelDto.Renavam, automovelDto.Oleokm, automovelDto.PastilhaFreioKm, automovelDto.IdPreco);

                string erros;
                if (!automovel.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Cadastro de automóveis", erros);
                }
                if (_automovelRepositorio.PlacaExiste(automovel.Placa))
                {
                    return RespostaPadrao<string>.Falha(false, "Cadastro de automóveis", "Placa já cadastrada");
                }

                _automovelRepositorio.Adicionar(automovel);
                return RespostaPadrao<string>.Sucesso(true, "Cadastro de automóveis","Automóvel cadastrado com sucesso!");

            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
