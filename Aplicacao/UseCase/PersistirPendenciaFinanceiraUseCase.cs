using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

public class PersistirPendenciaFinanceiraUseCase
{
    private readonly ICrud<PendenciaFinanceiraDTO> pendenciaRepositorio;
    private readonly ICrud<ParcelaDTO> parcelaRepositorio;
    private LocacaoDTO locacao;


    public PersistirPendenciaFinanceiraUseCase(ICrud<PendenciaFinanceiraDTO> pendenciaRepositorio, ICrud<ParcelaDTO> parcelaRepositorio, LocacaoDTO locacao)
    {
        this.pendenciaRepositorio = pendenciaRepositorio;
        this.parcelaRepositorio = parcelaRepositorio;
        this.locacao = locacao;

    }

    public void Executar(PendenciaFinanceiraDTO pendencia)
    {
        // Persistir Pendência Financeira no banco
        pendenciaRepositorio.Adicionar(pendencia);

        foreach (var parcela in pendencia.Parcelas)
        {
            var parcelaDto = new ParcelaDTO(parcela.ValorParcela, parcela.DataVencimento)
            {
                DataCriacao = parcela.DataCriacao,
                PendenciaFinanceiraId = parcela.Id
            };

            parcelaRepositorio.Adicionar(parcelaDto);
        }

    }

}
