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
    public class ListarPendenciaFinanceiraUseCase
    {

        private readonly ICrud<PendenciaFinanceiraDTO> pendenciaRepositorio;
        public ListarPendenciaFinanceiraUseCase(ICrud<PendenciaFinanceiraDTO> pendenciaRepositorio)
        {
            this.pendenciaRepositorio = pendenciaRepositorio;
        }
        public void Executar()
        {
            var lista = pendenciaRepositorio.ListarTodos();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public PendenciaFinanceiraDTO? ExecutarRecuperarPorId(int id)
        {
            return pendenciaRepositorio.RecuperarPorId(id);
        }
    }
}