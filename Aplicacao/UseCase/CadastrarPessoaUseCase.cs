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
    public class CadastrarPessoaUseCase
    {
        private readonly ICrud<PessoaDTO> pessoaRepositorio;
        public CadastrarPessoaUseCase(ICrud<PessoaDTO> pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void Executar(PessoaDTO _pessoa)
        {
            try
            {
                pessoaRepositorio.Adicionar(_pessoa);
            }
            catch (MySqlException ex) { Console.WriteLine(ex.StackTrace); }
        }
    }
}
