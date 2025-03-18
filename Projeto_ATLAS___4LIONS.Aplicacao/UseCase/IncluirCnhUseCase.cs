using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirCnhUseCase : IIncluirCnhUseCase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public IncluirCnhUseCase(IPessoaRepositorio pessoaRepositorio)
        {
          _pessoaRepositorio = pessoaRepositorio;
        }
        public RespostaPadrao<string> Executar(PessoaDTO pessoaDto, string numeroCnh, DateTime vencimentoCnh)
        {
            var pessoaCnh = PessoaCnh.Create(pessoaDto.Id, pessoaDto.DataCriacao, pessoaDto.Contato, pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro,numeroCnh, vencimentoCnh);

            string erros;
            if (!pessoaCnh.Validacao(out erros))
            {
                return RespostaPadrao<string>.Falha(false,"Inclusão de CNH", erros);
            }
            try
            {        
                _pessoaRepositorio.IncluirCNH(pessoaCnh.Id, numeroCnh, vencimentoCnh);

                return RespostaPadrao<string>.Sucesso(true, "Inclusão de CNH","CNH vínculada com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
