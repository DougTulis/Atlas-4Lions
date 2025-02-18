using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirCnhUseCase : IIncluirCnhUseCase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public IncluirCnhUseCase(IPessoaRepositorio pessoaRepositorio)
        {
          _pessoaRepositorio = pessoaRepositorio;
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
                    return;
                }
                _pessoaRepositorio.IncluirCNH(pessoaDto.Id, numeroCnh, vencimentoCnh);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
