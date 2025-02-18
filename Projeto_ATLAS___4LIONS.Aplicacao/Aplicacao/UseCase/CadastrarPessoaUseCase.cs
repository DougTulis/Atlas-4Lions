using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
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
                    string erros = "";
                    foreach (Notificacao notificacao in pessoa.Notificacoes)
                    {
                        erros += $"{notificacao.NomePropriedade}: {notificacao.Mensagem}\n";
                    }
                    throw new Exception(erros);
                }

                pessoaRepositorio.Adicionar(pessoaDto);
            }
            catch (MySqlException ex)
            {
              //
            }
        }

    }
}
