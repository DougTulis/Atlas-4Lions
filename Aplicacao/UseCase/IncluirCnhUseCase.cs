using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirCnhUseCase
    {
        private readonly PessoaRepositorio pessoaRepositorio;
        public IncluirCnhUseCase(PessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }
        public void Executar(PessoaDTO pessoaDto, string numeroCnh, DateTime vencimentoCnh)
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
                    VencimentoCnh = vencimentoCnh,
                    NumeroCnh = numeroCnh,
                };

                if (!pessoa.ValidacaoCnh())
                {
                    Thread.Sleep(2000);
                    MenuInicial.Exibir();
                }
                pessoaRepositorio.IncluirCNH(pessoaDto.Id, numeroCnh, vencimentoCnh);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
