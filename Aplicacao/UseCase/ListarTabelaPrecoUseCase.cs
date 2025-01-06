using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
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
                foreach (var item in tabelaRepositorio.Listar())
                {
                    Console.WriteLine(item);
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void ExecutarListarPor(Func<TabelaPrecoDTO, bool> filtro)
        {
            foreach (var item in tabelaRepositorio.Listar().Where(filtro))
            {
                Console.WriteLine(item);
            }
        }
        public TabelaPrecoDTO ExecutarRecuperarPor (Func<TabelaPrecoDTO, bool> filtro)
        {
            var lista = tabelaRepositorio.Listar();
            return lista.FirstOrDefault(filtro);
        }

    }
}
