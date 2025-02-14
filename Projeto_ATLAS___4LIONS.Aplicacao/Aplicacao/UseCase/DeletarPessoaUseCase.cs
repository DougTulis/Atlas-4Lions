﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class DeletarPessoaUseCase
    {
        private readonly IPessoaRepositorio pessoaRepositorio;
        public DeletarPessoaUseCase(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }
        public void Executar(PessoaDTO pessoaDto)
        {
            try
            {
                var _pessoa = new Pessoa
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

                if (!_pessoa.Validacao())
                {
                    return;
                }
                pessoaRepositorio.Deletar(pessoaDto);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
