using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPrecoAutomovelUseCase
    {
        private readonly ICrud<TabelaPrecoDTO> tabelaRepositorio;
        public CadastrarPrecoAutomovelUseCase(ICrud<TabelaPrecoDTO> tabelaRepositorio)
        {
            this.tabelaRepositorio = tabelaRepositorio;
        }
        public void Executar(TabelaPrecoDTO tabelaPrecoDto)
        {
            try
            {
                var tabelaPreco = new TabelaPreco
                {
                    Id = tabelaPrecoDto.Id,
                    Valor = tabelaPrecoDto.Valor,
                    Descricao = tabelaPrecoDto.Descricao,
                    AutomovelId = tabelaPrecoDto.AutomovelId,
                    DataCriacao = DateTime.Now
                };


                if (!tabelaPreco.Validacao())
                {
                    Thread.Sleep(2000);
                    MenuInicial.Exibir();
                }

                tabelaRepositorio.Adicionar(tabelaPrecoDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
