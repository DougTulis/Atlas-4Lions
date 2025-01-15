using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarLocacaoUseCase
    {
        private readonly ICrud<LocacaoDTO> locacaoRepositorio;
        public CadastrarLocacaoUseCase(ICrud<LocacaoDTO> locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }
        public void Executar(LocacaoDTO locacaoDto)
        {
            try
            {
                var locacao = new Locacao
                {
                    Saida = locacaoDto.Saida,
                    Retorno = locacaoDto.Retorno,
                    TipoLocacao = locacaoDto.TipoLocacao,
                    ValorTotal = locacaoDto.ValorTotal,
                    Locatario = new Pessoa { Id = locacaoDto.Locatario.Id },
                    Condutor = new Pessoa { Id = locacaoDto.Condutor.Id },
                    Automovel = new Automovel { Id = locacaoDto.Automovel.Id },
                    PendenciaFinanceira = new PendenciaFinanceira { Id = locacaoDto.PendenciaFinanceira.Id },
                    Status = locacaoDto.Status
                };

                if (!locacao.Validacao())
                {
                    Thread.Sleep(2000);
                    MenuInicial.Exibir();
                }

                locacaoRepositorio.Adicionar(locacaoDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

