using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
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
        public void Executar(LocacaoDTO _locacao)
        {
            try
            {


             locacaoRepositorio.Adicionar(_locacao);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

