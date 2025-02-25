﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPessoaUseCase : ICadastrarPessoaUseCase
    {
        private readonly IPessoaRepositorio pessoaRepositorio;
        public CadastrarPessoaUseCase(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public RespostaPadrao<string> Executar(PessoaDTO pessoaDto)
        {
            try
            {
                //var pessoa = new Pessoa
                //{
                //    //Id = pessoaDto.Id,
                //    Nome = pessoaDto.Nome,
                //    Email = pessoaDto.Email,
                //    Contato = pessoaDto.Contato,
                //    DataNascimento = pessoaDto.DataNascimento,
                //    Cpf = pessoaDto.Cpf,
                //    //DataCriacao = pessoaDto.DataCriacao,
                //    VencimentoCnh = pessoaDto.VencimentoCnh,
                //    NumeroCnh = pessoaDto.NumeroCnh
                //};

                var pessoa = Pessoa.Create(pessoaDto.Nome, pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro);

                string erros;
                if (!pessoa.Validacao(out erros))
                {
                 
                    return RespostaPadrao<string>.Falha(true, erros, "ERRO");
                }
                pessoaRepositorio.Adicionar(pessoa);

                return RespostaPadrao<string>.Sucesso(true, "Pessoa cadastrada com sucesso!", null);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
