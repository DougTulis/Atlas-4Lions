using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPrecoAutomovelUseCase
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
                    AutomovelId = tabelaPrecoDto.AutomovelId,
                    DataCriacao = DateTime.Now
                };


                if (!tabelaPreco.Validacao())
                {
                    Thread.Sleep(2000);
                    return;
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
