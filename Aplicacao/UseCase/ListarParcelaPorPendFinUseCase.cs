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
    public class ListarParcelaPorPendFinUseCase
    {
        private readonly ICrud<ParcelaDTO> parcelaRepositorio;
        public ListarParcelaPorPendFinUseCase(ICrud<ParcelaDTO> parcelaRepositorio)
        {
            this.parcelaRepositorio = parcelaRepositorio;
        }
        public void Executar(int id)
        {

            ParcelaRepositorio parcelaRepositorio = new ParcelaRepositorio();
            var lista = parcelaRepositorio.ListarPorPendFin(id);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
