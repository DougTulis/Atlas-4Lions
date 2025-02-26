using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
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
        public RespostaPadrao<string> Executar(PessoaDTO pessoaDto)
        {
            try
            {
                var pessoa = Pessoa.Create(pessoaDto.Nome, pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro, null, null);

                string erros;
                if (!pessoa.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, erros, "ERRO");
                }
                pessoaRepositorio.Deletar(pessoaDto);

                return RespostaPadrao<string>.Sucesso(true, pessoa.Nome + " excluído(a) com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
