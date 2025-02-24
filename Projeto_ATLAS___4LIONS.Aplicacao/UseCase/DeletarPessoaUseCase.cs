using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class DeletarPessoaUseCase : IDeletarPessoaUseCase
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
                var pessoa = Pessoa.Create(pessoaDto.Nome, pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro);

                if (!pessoa.Validacao())
                {
                    return;
                }
                pessoaRepositorio.Deletar(pessoaDto);

            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
