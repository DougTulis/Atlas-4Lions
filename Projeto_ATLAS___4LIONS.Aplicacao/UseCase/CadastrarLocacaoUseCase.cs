using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarLocacaoUseCase : ICadastrarLocacaoUseCase
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IPendenciaFinanceiraService _pendenciaFinanceiraService;
        private readonly IParcelaService _parcelaService;


        public CadastrarLocacaoUseCase(
            ILocacaoRepositorio locacaoRepositorio,
            ITabelaPrecoRepositorio tabelaPrecoRepositorio,
            IAutomovelRepositorio automovelRepositorio,
            IPessoaRepositorio pessoaRepositorio,
            ICalculoValorLocacaoService calculoValorLocacaoService,
            IPendenciaFinanceiraService pendenciaFinanceiraService,
            IParcelaService parcelaService)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _pendenciaFinanceiraService = pendenciaFinanceiraService;
            _parcelaService = parcelaService;
        }
        public void Executar(LocacaoDTO locacaoDto,int quantidadeParcelas)
        {
            //  Buscar o Locatario e fabrica o model
            var locatarioDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);

            var locatario = Pessoa.Create(locatarioDto.Nome, locatarioDto.Email, locatarioDto.Contato, locatarioDto.TipoPessoa, locatarioDto.NumeroDocumento, locatarioDto.DataRegistro);

            //  Buscar o CondutorDto e fabrica o model
            var condutorDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);
            var condutor = Pessoa.Create(condutorDto.Nome, condutorDto.Email, condutorDto.Contato, condutorDto.TipoPessoa, condutorDto.NumeroDocumento, condutorDto.DataRegistro);

            // Buscar o automóvel, preco por id e fabrica o model dos dois
            var automovelDto = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);
            var precoDto = _tabelaPrecoRepositorio.RecuperarPorId(automovelDto.IdPreco);
            var preco = TabelaPreco.Create(precoDto.Descricao, precoDto.Valor);
            var automovel = Automovel.Create(automovelDto.Modelo, automovelDto.Placa, automovelDto.Cor, automovelDto.Status, automovelDto.Ano, automovelDto.Chassi, automovelDto.Renavam, automovelDto.Oleokm, automovelDto.PastilhaFreioKm, preco);

            var locacao = Locacao.Create(locacaoDto.Saida, locacaoDto.Retorno, locacaoDto.TipoLocacao, locatario, condutor, automovel, locacaoDto.Status);

            if (!locacao.Validacao())
            {
                throw new Exception("A locação não passou na validação de regras de negócio.");
            }

            var pendencia = _pendenciaFinanceiraService.CriarPendencia(locacao.ValorTotal,quantidadeParcelas);

            {
                if (!pendencia.Validacao())
                {
                    throw new Exception("A pendência financeira não passou na validação.");
                }

                // aqui vai gerar todas as parcelas....
                _parcelaService.GerarParcelas(pendencia, pendencia.QuantidadeParcelas);

                automovel.AlterarParaAlugado(); // aqui altera pra garágem o status do automovel.

                try
                {
                    _automovelRepositorio.AtualizarStatus(automovel.Id, automovel.Status);
                    _locacaoRepositorio.Adicionar(locacao);
                }
                catch (MySqlException ex)
                {
                    throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
                }
            }

        }
    }
}
