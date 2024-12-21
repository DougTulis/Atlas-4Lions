using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
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

            if (_pessoa.Validacao())
            {
                pessoaRepositorio.Adicionar(_pessoa);
            }
            else
            {
                Console.WriteLine("Tente novamente... Voltando ao menu inicial");
                Thread.Sleep(2000);
                Console.Clear();
                MenuInicial.Exibir();
            }
        }
    }
}
