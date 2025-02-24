using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarVeiculoUseCase : ICadastrarVeiculoUseCase
    {
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _precoRepositorio;
        public CadastrarVeiculoUseCase(IAutomovelRepositorio automovelRepositorio,ITabelaPrecoRepositorio precoRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
            _precoRepositorio = precoRepositorio;
        }

        public void Executar(AutomovelDTO automovelDto)
        {
            try
            {
                var precoDto = _precoRepositorio.RecuperarPorId(automovelDto.Id);
                var preco = TabelaPreco.Create(precoDto.Descricao, precoDto.Valor);
                var automovel = Automovel.Create(automovelDto.Modelo, automovelDto.Placa, automovelDto.Cor, automovelDto.Status, automovelDto.Ano, automovelDto.Chassi, automovelDto.Renavam, automovelDto.Oleokm, automovelDto.PastilhaFreioKm, preco);

                if (!automovel.Validacao())
                {
                    
                }
                _automovelRepositorio.Adicionar(automovel);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
