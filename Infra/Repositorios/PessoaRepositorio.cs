﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PessoaRepositorio : ICrud<PessoaDTO>

    {
        public void Adicionar(PessoaDTO pessoaDto)
        {

            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

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
                Thread.Sleep(2000);
                MenuInicial.Exibir();
            }

            string sql = @"
                        INSERT INTO pessoa (Nome, Contato, Email, DataCriacao, DataNascimento, Cpf, NumeroCnh, VencimentoCnh)
                        VALUES (@Nome, @Contato, @Email, @DataCriacao, @DataNascimento, @Cpf, @NumeroCnh, @VencimentoCnh)";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Nome", _pessoa.Nome);
                cmd.Parameters.AddWithValue("@Contato", _pessoa.Contato);
                cmd.Parameters.AddWithValue("@Email", _pessoa.Email);
                cmd.Parameters.AddWithValue("@DataCriacao", _pessoa.DataCriacao);
                cmd.Parameters.AddWithValue("@DataNascimento", _pessoa.DataNascimento);
                cmd.Parameters.AddWithValue("@Cpf", _pessoa.Cpf);
                cmd.Parameters.AddWithValue("@NumeroCnh", _pessoa.NumeroCnh);
                cmd.Parameters.AddWithValue("@VencimentoCnh", _pessoa.VencimentoCnh);
                cmd.ExecuteNonQuery();
            }
        }
        public void Atualizar(PessoaDTO pessoaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
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
                Thread.Sleep(2000);
                MenuInicial.Exibir();
            }

            string sql = @" UPDATE pessoa SET Nome = @Nome, Telefone = @Telefone, Email = @Email,  DataAtualizacao = @DataAtualizacao  WHERE Id = @Id";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Nome", _pessoa.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _pessoa.Contato);
                cmd.Parameters.AddWithValue("@Email", _pessoa.Email);
                cmd.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
                cmd.Parameters.AddWithValue("@Id", _pessoa.Id);
                cmd.ExecuteNonQuery();
            }
        }
        public void Deletar(PessoaDTO pessoaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

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
                Thread.Sleep(2000);
                MenuInicial.Exibir();
            }
            string sql = $"DELETE FROM pessoa WHERE Id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", _pessoa.Id);
            cmd.ExecuteNonQuery();
        }
        public IEnumerable<PessoaDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<PessoaDTO>();
            string sql = "SELECT * FROM pessoa";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            using MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int idPessoa = Convert.ToInt32(dataReader["Id"]);
                string nome = Convert.ToString(dataReader["Nome"]);
                string contato = Convert.ToString(dataReader["Contato"]);
                string email = Convert.ToString(dataReader["Email"]);
                string cpf = Convert.ToString(dataReader["Cpf"]);
                DateTime nascimento = Convert.ToDateTime(dataReader["DataNascimento"]);
                DateTime dataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]);
                DateTime? vencimentoCnh = dataReader["VencimentoCnh"] != DBNull.Value ? Convert.ToDateTime(dataReader["VencimentoCnh"]) : null ;
                string? numeroCnh = dataReader["NumeroCnh"] != DBNull.Value ? Convert.ToString(dataReader["NumeroCnh"]) : null;
                var pessoa = new PessoaDTO(nome, email, contato, nascimento, cpf) { Id = idPessoa, DataCriacao = dataCriacao, VencimentoCnh = vencimentoCnh, NumeroCnh = numeroCnh};
                lista.Add(pessoa);
            }
            return lista;
        }
        public PessoaDTO RecuperarPor(Func<PessoaDTO, bool> filtro)
        {
            IEnumerable<PessoaDTO> pessoaLista = Listar();

            return pessoaLista.FirstOrDefault(filtro);
        }
    }
}