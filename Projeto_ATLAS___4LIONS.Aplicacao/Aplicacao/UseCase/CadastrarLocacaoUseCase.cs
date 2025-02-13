using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarLocacaoUseCase
    {
        private readonly ILocacaoRepositorio locacaoRepositorio;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly IPendenciaFinanceiraRepositorio pendenciaRepositorio;

        public CadastrarLocacaoUseCase(
            ILocacaoRepositorio locacaoRepositorio,
            IPessoaRepositorio pessoaRepositorio,
            IAutomovelRepositorio automovelRepositorio,
            IPendenciaFinanceiraRepositorio pendenciaRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
            this.pessoaRepositorio = pessoaRepositorio;
            this.automovelRepositorio = automovelRepositorio;
            this.pendenciaRepositorio = pendenciaRepositorio;
        }

        public int Executar(LocacaoDTO locacaoDto)
        {
            try
            { 
                PessoaDTO locatarioDto = pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);
                PessoaDTO condutorDto = pessoaRepositorio.RecuperarPorId(locacaoDto.IdCondutor);
                AutomovelDTO automovelDto = automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);
        
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


                if (!locacao.Validacao())
                {
                    Console.WriteLine("Erro na validação da locação.");
                    return -1;
                }

                return locacaoRepositorio.Adicionar(locacaoDto,condutor,locatario,automovel);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
                return -1;
            }
        }
    }
}

