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
    public class CadastrarPendenciaFinanceiraUseCase
    {
        private readonly ICrud<PendenciaFinanceiraDTO> pendenciaRepositorio;
        public CadastrarPendenciaFinanceiraUseCase(ICrud<PendenciaFinanceiraDTO> pendenciaRepositorio)
        {
            this.pendenciaRepositorio = pendenciaRepositorio;
        }
        public void Executar(PendenciaFinanceiraDTO pendencia)
        {
            try
            {
                pendenciaRepositorio.Adicionar(pendencia);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
