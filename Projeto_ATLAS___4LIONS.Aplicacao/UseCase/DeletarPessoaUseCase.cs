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
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public DeletarPessoaUseCase(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        public RespostaPadrao<string> Executar(Guid id)
        {

            var pessoaDto = _pessoaRepositorio.RecuperarPorId(id);

            var pessoaCnh = PessoaCnh.Create(pessoaDto.Id, pessoaDto.DataCriacao, pessoaDto.Nome, pessoaDto.Contato, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro, pessoaDto.NumeroCnh, pessoaDto.VencimentoCnh);

            try
            {
                bool temLocacaoVinculada = _pessoaRepositorio.TemLocacaoVinculada(id);

                string erros;
                if (pessoaCnh.ValidacaoExclusao(temLocacaoVinculada, out erros))
                {
                   return RespostaPadrao<string>.Falha(false, "Exclusão de pessoas", erros);
                }
                _pessoaRepositorio.Deletar(id);
                return RespostaPadrao<string>.Sucesso(true, "Exclusão de pessoas", "Pessoa excluida com sucesso!");
            }

            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
