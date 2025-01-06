using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AlterarStatusLocacaoUseCase
    {

        private readonly LocacaoRepositorio locacaoRepositorio;
        public AlterarStatusLocacaoUseCase(LocacaoRepositorio locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }
        public void Executar(int locacaoId, EStatusLocacao novoStatus)
        {
            try
            {
                locacaoRepositorio.AtualizarStatus(locacaoId, novoStatus);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}