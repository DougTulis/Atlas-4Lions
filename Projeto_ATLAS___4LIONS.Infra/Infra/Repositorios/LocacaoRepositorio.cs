using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class LocacaoRepositorio : ILocacaoRepositorio
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public LocacaoRepositorio(IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, IMySqlAdaptadorConexao conexaoAdapter)
        {
            _pessoaRepositorio = pessoaRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _conexaoAdapter = conexaoAdapter;
        }

        public int Adicionar(LocacaoDTO locacaoDto)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                // 🔥 Buscar objetos COMPLETOS
                var locatarioDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);


                var condutorDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdCondutor);


                var automovelDto = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);
                 

            
                var locacao = new Locacao
                {
                    Saida = locacaoDto.Saida,
                    Retorno = locacaoDto.Retorno,
                    TipoLocacao = locacaoDto.TipoLocacao,
                    ValorTotal = locacaoDto.ValorTotal,
                    Locatario = new Pessoa
                    {
                        Id = locatarioDto.Id,
                        Nome = locatarioDto.Nome,
                        Email = locatarioDto.Email,
                        Contato = locatarioDto.Contato,
                        Cpf = locatarioDto.Cpf,
                        Cnpj = locatarioDto.Cnpj,
                        DataNascimento = locatarioDto.DataNascimento,
                        NumeroCnh = locatarioDto.NumeroCnh,
                        VencimentoCnh = locatarioDto.VencimentoCnh
                    },
                    Condutor = new Pessoa
                    {
                        Id = condutorDto.Id,
                        Nome = condutorDto.Nome,
                        Email = condutorDto.Email,
                        Contato = condutorDto.Contato,
                        Cpf = condutorDto.Cpf,
                        Cnpj = condutorDto.Cnpj,
                        DataNascimento = condutorDto.DataNascimento,
                        NumeroCnh = condutorDto.NumeroCnh,
                        VencimentoCnh = condutorDto.VencimentoCnh
                    },
                    Automovel = new Automovel
                    {
                        Id = automovelDto.Id,
                        Modelo = automovelDto.Modelo,
                        Placa = automovelDto.Placa,
                        Cor = automovelDto.Cor,
                        Chassi = automovelDto.Chassi,
                        Renavam = automovelDto.Renavam,
                        Oleokm = automovelDto.Oleokm,
                        PastilhaFreioKm = automovelDto.PastilhaFreioKm,
                        DataCriacao = automovelDto.DataCriacao,
                        Status = automovelDto.Status
                    },
                    Status = EStatusLocacao.ANDAMENTO
                };

                // 🔥 Persistindo APENAS o Model no banco
                string sql = @"
                INSERT INTO Locacao 
                (Saida, Retorno, TipoLocacao, ValorTotal, LocatarioId, CondutorId, AutomovelId, statusLocacao)
                VALUES 
                (@Saida, @Retorno, @TipoLocacao, @ValorTotal, @LocatarioId, @CondutorId, @AutomovelId, @statusLocacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@Retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@TipoLocacao", locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@ValorTotal", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@LocatarioId", locacao.Locatario.Id);
                    cmd.Parameters.AddWithValue("@CondutorId", locacao.Condutor.Id);
                    cmd.Parameters.AddWithValue("@AutomovelId", locacao.Automovel.Id);
                    cmd.Parameters.AddWithValue("@statusLocacao", locacao.Status);

                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }

        public void Atualizar(LocacaoDTO locacaoDto)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();


                var locatario = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);


                var condutor = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdCondutor);


                var automovel = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);
   
                var locacao = new Locacao
                {
                    Id = locacaoDto.Id,
                    Saida = locacaoDto.Saida,
                    Retorno = locacaoDto.Retorno,
                    TipoLocacao = locacaoDto.TipoLocacao,
                    ValorTotal = locacaoDto.ValorTotal,
                    Locatario = new Pessoa
                    {
                        Id = locatario.Id,
                        Nome = locatario.Nome,
                        Email = locatario.Email,
                        Contato = locatario.Contato,
                        Cpf = locatario.Cpf,
                        Cnpj = locatario.Cnpj,
                        DataNascimento = locatario.DataNascimento,
                        NumeroCnh = locatario.NumeroCnh,
                        VencimentoCnh = locatario.VencimentoCnh
                    },
                    Condutor = new Pessoa
                    {
                        Id = condutor.Id,
                        Nome = condutor.Nome,
                        Email = condutor.Email,
                        Contato = condutor.Contato,
                        Cpf = condutor.Cpf,
                        Cnpj = condutor.Cnpj,
                        DataNascimento = condutor.DataNascimento,
                        NumeroCnh = condutor.NumeroCnh,
                        VencimentoCnh = condutor.VencimentoCnh
                    },
                    Automovel = new Automovel
                    {
                        Id = automovel.Id,
                        Modelo = automovel.Modelo,
                        Placa = automovel.Placa,
                        Cor = automovel.Cor,
                        Chassi = automovel.Chassi,
                        Renavam = automovel.Renavam,
                        Oleokm = automovel.Oleokm,
                        PastilhaFreioKm = automovel.PastilhaFreioKm,
                        DataCriacao = automovel.DataCriacao,
                        Status = automovel.Status
                    },
                    Status = locacaoDto.Status
                };

                string sql = @"
        UPDATE Locacao 
        SET Saida = @Saida, Retorno = @Retorno, TipoLocacao = @TipoLocacao,
            ValorTotal = @ValorTotal, LocatarioId = @LocatarioId, CondutorId = @CondutorId,
            AutomovelId = @AutomovelId, statusLocacao = @statusLocacao
        WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", locacao.Id);
                    cmd.Parameters.AddWithValue("@Saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@Retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@TipoLocacao", locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@ValorTotal", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@LocatarioId", locacao.Locatario.Id);
                    cmd.Parameters.AddWithValue("@CondutorId", locacao.Condutor.Id);
                    cmd.Parameters.AddWithValue("@AutomovelId", locacao.Automovel.Id);
                    cmd.Parameters.AddWithValue("@statusLocacao", locacao.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Deletar(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "DELETE FROM Locacao WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<LocacaoDTO> ListarTodas()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM Locacao";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var dataReader = cmd.ExecuteReader())
                {
                    return PopularListaDTO(dataReader);
                }
            }
        }
        public LocacaoDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM Locacao WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = PopularListaDTO(dataReader);
                        return lista.FirstOrDefault();
                    }
                }
            }
        }
        private IEnumerable<LocacaoDTO> PopularListaDTO(MySqlDataReader dataReader)
        {
            var lista = new List<LocacaoDTO>();

            while (dataReader.Read())
            {
                var locacaoDto = new LocacaoDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Saida = Convert.ToDateTime(dataReader["Saida"]),
                    Retorno = Convert.ToDateTime(dataReader["Retorno"]),
                    TipoLocacao = (ETipoLocacao)Convert.ToInt32(dataReader["TipoLocacao"]),
                    ValorTotal = Convert.ToDecimal(dataReader["ValorTotal"]),
                    IdLocatario = Convert.ToInt32(dataReader["LocatarioId"]),
                    IdCondutor = Convert.ToInt32(dataReader["CondutorId"]),
                    IdAutomovel = Convert.ToInt32(dataReader["AutomovelId"]),
                    Status = (EStatusLocacao)Convert.ToInt32(dataReader["statusLocacao"])
                };

                lista.Add(locacaoDto);
            }

            return lista;
        }

        public void AtualizarStatusLocacao(int locacaoId, EStatusLocacao novoStatus)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "UPDATE Locacao SET statusLocacao = @Status WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Status", (int)novoStatus);
                    cmd.Parameters.AddWithValue("@Id", locacaoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<LocacaoDTO> ListarStatusAndamento()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM Locacao WHERE statusLocacao = @statusLocacao";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@statusLocacao", (int)EStatusLocacao.ANDAMENTO);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularListaDTO(dataReader);
                    }
                }
            }
        }
    }
}
