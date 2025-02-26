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
            var pessoa = Pessoa.Create(pessoaDto.Nome, pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro, pessoaDto.NumeroCnh, pessoaDto.VencimentoCnh);

            string erros;
            if (!pessoa.ValidacaoCnh(out erros))
            {
                return RespostaPadrao<string>.Falha(false, erros, "ERRO");
            }

            try
            {        
                _pessoaRepositorio.IncluirCNH(pessoa.Id, numeroCnh, vencimentoCnh);

                return RespostaPadrao<string>.Sucesso(true, "CNH vínculada com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
