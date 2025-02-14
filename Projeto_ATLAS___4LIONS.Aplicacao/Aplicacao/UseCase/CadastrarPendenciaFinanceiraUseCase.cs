using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPendenciaFinanceiraUseCase
    {
        private readonly IPendenciaFinanceiraRepositorio pendenciaRepositorio;
        private readonly ILocacaoRepositorio locacaoRepositorio;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly ITabelaPrecoRepositorio precoRepositorio;


        public CadastrarPendenciaFinanceiraUseCase(IPendenciaFinanceiraRepositorio pendenciaRepositorio, ILocacaoRepositorio locacaoRepositorio, IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio precoRepositorio)
        {
            this.pendenciaRepositorio = pendenciaRepositorio;
            this.locacaoRepositorio = locacaoRepositorio;
            this.pessoaRepositorio = pessoaRepositorio;
            this.automovelRepositorio = automovelRepositorio;
            this.precoRepositorio = precoRepositorio;
        }

        public void Executar(PendenciaFinanceiraDTO pendenciaDto)
        {
            try
            {
                LocacaoDTO locacaoDto = locacaoRepositorio.RecuperarPorId(pendenciaDto.IdLocacao);
                PessoaDTO locatarioDto = pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);
                PessoaDTO condutorDto = pessoaRepositorio.RecuperarPorId(locacaoDto.IdCondutor);
                AutomovelDTO automovelDto = automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);

                if (automovelDto == null)
                {
                    throw new Exception("O automóvel não foi encontrado.");
                }

                if (!automovelDto.IdPreco.HasValue)
                {
                    throw new Exception("O automóvel não possui um preço associado.");
                }

                TabelaPrecoDTO tabelaPrecoDto = precoRepositorio.RecuperarPorId(automovelDto.IdPreco.Value);

                Pessoa locatario = new Pessoa
                {
                    Id = locatarioDto.Id,
                    Nome = locatarioDto.Nome,
                    Cpf = locatarioDto.Cpf,
                    Contato = locatarioDto.Contato,
                    Email = locatarioDto.Email,
                    NumeroCnh = locatarioDto.NumeroCnh,
                    VencimentoCnh = locatarioDto.VencimentoCnh,
                    DataNascimento = locatarioDto.DataNascimento
                };

                Pessoa condutor = new Pessoa
                {
                    Id = condutorDto.Id,
                    Nome = condutorDto.Nome,
                    Cpf = condutorDto.Cpf,
                    Contato = condutorDto.Contato,
                    Email = condutorDto.Email,
                    NumeroCnh = condutorDto.NumeroCnh,
                    VencimentoCnh = condutorDto.VencimentoCnh,
                    DataNascimento = condutorDto.DataNascimento
                };

                Automovel automovel = new Automovel
                {
                    Id = automovelDto.Id,
                    Modelo = automovelDto.Modelo,
                    Placa = automovelDto.Placa,
                    Cor = automovelDto.Cor,
                    Status = Dominio.ValueObjects.Enums.EStatusVeiculo.ALUGADO,
                    Chassi = automovelDto.Chassi,
                    Renavam = automovelDto.Renavam
                };

                Locacao locacao = new Locacao
                {
                    Saida = locacaoDto.Saida,
                    Retorno = locacaoDto.Retorno,
                    TipoLocacao = locacaoDto.TipoLocacao,
                    ValorTotal = locacaoDto.ValorTotal,
                    Locatario = locatario,
                    Condutor = condutor,
                    Automovel = automovel,
                    Status = locacaoDto.Status
                };
                int quantidadeDias = (locacaoDto.Retorno - locacaoDto.Saida).Days;
                decimal valorTotal = tabelaPrecoDto.Valor * quantidadeDias;


                var pendencia = new PendenciaFinanceira(pendenciaDto.TransacaoId,valorTotal,locacao)
                {
                    DataCriacao = pendenciaDto.DataCriacao
                };

                if (!pendencia.Validacao())
                {
                    Thread.Sleep(2000);
                    return;
                }
                pendenciaRepositorio.Adicionar(pendenciaDto);
               
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
