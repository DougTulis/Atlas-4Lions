using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class AutomovelRepositorio : ICrud<AutomovelDTO>
    {
        public void Adicionar(AutomovelDTO automovelDTO)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = @"
                        INSERT INTO automovel (Modelo, Placa, Cor, Status, ValorDiaria, Chassi,Renavam,OleoKm,DataCriacao)
                        VALUES (@Modelo, @Placa, @Cor, @Status, @ValorDiaria, @Chassi, @Renavam,@OleoKm, @DataCriacao)"
            ;

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Modelo", automovelDTO.Modelo);
                cmd.Parameters.AddWithValue("@Placa", automovelDTO.Placa);
                cmd.Parameters.AddWithValue("@Cor", automovelDTO.Cor);
                cmd.Parameters.AddWithValue("@Status", automovelDTO.Status);
                cmd.Parameters.AddWithValue("@ValorDiaria", automovelDTO.ValorDiaria);
                cmd.Parameters.AddWithValue("@Chassi", automovelDTO.Chassi);
                cmd.Parameters.AddWithValue("@Renavam", automovelDTO.Renavam);
                cmd.Parameters.AddWithValue("@OleoKm", automovelDTO.Oleokm);
                cmd.Parameters.AddWithValue("@DataCriacao", automovelDTO.DataCriacao);
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(AutomovelDTO objeto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(AutomovelDTO objeto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AutomovelDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public AutomovelDTO? RecuperarPor(Func<AutomovelDTO, bool> resultado)
        {
            throw new NotImplementedException();
        }
    }
}
