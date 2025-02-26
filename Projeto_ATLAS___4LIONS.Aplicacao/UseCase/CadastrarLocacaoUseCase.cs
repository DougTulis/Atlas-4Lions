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
    public class CadastrarLocacaoUseCase : ICadastrarLocacaoUseCase
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IPendenciaFinanceiraService _pendenciaFinanceiraService;
        private readonly IParcelaService _parcelaService;
        private readonly ICalculoValorLocacaoService _calculoValorLocacaoService;


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
            _calculoValorLocacaoService = calculoValorLocacaoService;
        }
        public RespostaPadrao<string> Executar(LocacaoDTO locacaoDto, int quantidadeParcelas)
        {
            var automovelDto = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);

            var precoDto = _tabelaPrecoRepositorio.RecuperarPorId(automovelDto.IdPreco);

            var valorTotal = _calculoValorLocacaoService.CalcularValorTotal(locacaoDto.Saida, locacaoDto.Retorno, precoDto.Valor);

              var locacao = Locacao.Create(locacaoDto.Saida, locacaoDto.Retorno, locacaoDto.TipoLocacao,valorTotal,locacaoDto.IdLocatario,locacaoDto.IdCondutor,locacaoDto.IdAutomovel,locacaoDto.PendenciaFinanceiraId,locacaoDto.Status);

            string erros;
            if (!locacao.Validacao(out erros))
            {
                return RespostaPadrao<string>.Falha(false, "Erros", erros);
            }

            var pendencia = _pendenciaFinanceiraService.CriarPendencia(locacao.ValorTotal,quantidadeParcelas);
            {
                if (!pendencia.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Erros", erros);
                }

                // aqui vai gerar todas as parcelas....
                _parcelaService.GerarParcelas(pendencia, pendencia.QuantidadeParcelas);

             //   automovel.AlterarParaAlugado(); 
                try
                {
                    _automovelRepositorio.AtualizarStatus(automovel.Id, );
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
