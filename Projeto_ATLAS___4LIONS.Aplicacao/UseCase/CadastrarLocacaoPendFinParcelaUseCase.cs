using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarLocacaoPendFinParcelaUseCase : ICadastrarLocacaoPendFinParcelaUseCase
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IPendenciaFinanceiraRepositorio _pendFinRepositorio;
        private readonly IPendenciaFinanceiraService _pendenciaFinanceiraService;
        private readonly IParcelaService _parcelaService;
        private readonly ICalculoValorLocacaoService _calculoValorLocacaoService;


        public CadastrarLocacaoPendFinParcelaUseCase(
            ILocacaoRepositorio locacaoRepositorio,
            ITabelaPrecoRepositorio tabelaPrecoRepositorio,
            IAutomovelRepositorio automovelRepositorio,
            IPessoaRepositorio pessoaRepositorio,
            ICalculoValorLocacaoService calculoValorLocacaoService,
            IPendenciaFinanceiraService pendenciaFinanceiraService,
            IParcelaService parcelaService,
            IPendenciaFinanceiraRepositorio pendFinRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _pendenciaFinanceiraService = pendenciaFinanceiraService;
            _parcelaService = parcelaService;
            _calculoValorLocacaoService = calculoValorLocacaoService;
            _pendFinRepositorio = pendFinRepositorio;
        }
        public RespostaPadrao<string> Executar(LocacaoDTO locacaoDto, int quantidadeParcelas)
        {
            try
            {
                var automovelDto = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);

                var precoDto = _tabelaPrecoRepositorio.RecuperarPorId(automovelDto.IdPreco);

                var valorTotal = _calculoValorLocacaoService.CalcularValorTotal(locacaoDto.Saida, locacaoDto.Retorno, precoDto.Valor,locacaoDto.TipoLocacao,quantidadeParcelas);

                var pendencia = _pendenciaFinanceiraService.CriarPendencia(valorTotal);

                var locacao = Locacao.Create(locacaoDto.Saida, locacaoDto.Retorno, locacaoDto.TipoLocacao, valorTotal, locacaoDto.IdLocatario, locacaoDto.IdCondutor, locacaoDto.IdAutomovel, locacaoDto.Status, pendencia.Id);

                string erros;
                if (!pendencia.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Cadastro de Locações", erros);
                }

                if (!locacao.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Cadastro de Locações", erros);
                }
                _pendFinRepositorio.Adicionar(pendencia);
                _locacaoRepositorio.Adicionar(locacao);
                _parcelaService.GerarParcelas(pendencia, quantidadeParcelas);
                _automovelRepositorio.AtualizarStatus(automovelDto.Id, EStatusVeiculo.ALUGADO);

                return RespostaPadrao<string>.Sucesso(true, "Cadastro de Locações","Locação cadastrada com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}

