using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
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

                var pessoa = Pessoa.Create(pessoaDto.Nome, pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro);

                if (!pessoa.ValidacaoCnh())
                {
                    return;
                }
                _pessoaRepositorio.IncluirCNH(pessoa.Id, numeroCnh, vencimentoCnh);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
