using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
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

        public void Executar(PessoaDTO pessoaDto)
        {
            try
            {
                var pessoa = new Pessoa
                {
                    Id = pessoaDto.Id,
                    Nome = pessoaDto.Nome,
                    Email = pessoaDto.Email,
                    Contato = pessoaDto.Contato,
                    DataNascimento = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.Cpf,
                    DataCriacao = pessoaDto.DataCriacao,
                    VencimentoCnh = pessoaDto.VencimentoCnh,
                    NumeroCnh = pessoaDto.NumeroCnh
                };

                if (!pessoa.Validacao())
                {
                    Thread.Sleep(2000);
                    MenuInicial.Exibir();
                }

                pessoaRepositorio.Adicionar(pessoaDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
