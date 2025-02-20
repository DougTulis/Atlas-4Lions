using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Servicos
{
    public class PendenciaFinanceiraServico : IPendenciaFinanceiraService
    {
        private readonly IPendenciaFinanceiraRepositorio _pendenciaRepo;
        private readonly IParcelaRepositorio _parcelaRepo;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepo;

        public PendenciaFinanceiraServico(IPendenciaFinanceiraRepositorio pendenciaRepo, IParcelaRepositorio parcelaRepo, ITabelaPrecoRepositorio tabelaPrecoRepo)
        {
            _pendenciaRepo = pendenciaRepo;
            _parcelaRepo = parcelaRepo;
            _tabelaPrecoRepo = tabelaPrecoRepo;
        }

        public void CriarPendenciaFinanceira(int idLocacao, int idPreco, int numeroParcelas)
        {
            var preco = _tabelaPrecoRepo.RecuperarPorId(idPreco);

            var pendenciaDto = new PendenciaFinanceiraDTO
            {
                TransacaoId = Guid.NewGuid(),
                DataCriacao = DateTime.Now,
                ValorTotal = preco.Valor,
                IdLocacao = idLocacao
            };

            _pendenciaRepo.Adicionar(pendenciaDto);

            CriarParcelas(pendenciaDto.Id, preco.Valor, numeroParcelas);
        }

        public void CriarParcelas(int idPendencia, decimal valorTotal, int numeroParcelas)
        {
            decimal valorParcela = valorTotal / numeroParcelas;
            List<ParcelaDTO> parcelas = new();

            for (int i = 0; i < numeroParcelas; i++)
            {
                parcelas.Add(new ParcelaDTO
                {
                    PendenciaFinanceiraId = idPendencia,
                    Sequencia = i + 1,
                    Valor = valorParcela,
                    DataVencimento = DateTime.Now.AddMonths(i + 1)
                });
            }

            _parcelaRepo.AdicionarVarias(parcelas);
        }
    }
}
