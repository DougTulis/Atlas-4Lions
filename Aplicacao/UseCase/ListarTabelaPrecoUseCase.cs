using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarTabelaPrecoUseCase
    {

        private readonly ICrud<TabelaPrecoDTO> tabelaRepositorio;
        public ListarTabelaPrecoUseCase(ICrud<TabelaPrecoDTO> tabelaRepositorio)
        {
            this.tabelaRepositorio = tabelaRepositorio;
        }


        public void Executar()
        {
            try
            {
                foreach (var item in tabelaRepositorio.ListarTodos())
                {
                    Console.WriteLine(item);
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public TabelaPrecoDTO? ExecutarRecuperarPorId(int id)
        {
           return tabelaRepositorio.RecuperarPorId(id);
        }
    }
}
