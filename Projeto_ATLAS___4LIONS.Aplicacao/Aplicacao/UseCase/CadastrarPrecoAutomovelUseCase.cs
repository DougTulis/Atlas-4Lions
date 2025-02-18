using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPrecoAutomovelUseCase : ICadastrarTabelaPrecoUseCase
    {
        private readonly ITabelaPrecoRepositorio tabelaRepositorio;
        public CadastrarPrecoAutomovelUseCase(ITabelaPrecoRepositorio tabelaRepositorio)
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
                    DataCriacao = DateTime.Now
                };


                if (!tabelaPreco.Validacao())
                {
                //
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
