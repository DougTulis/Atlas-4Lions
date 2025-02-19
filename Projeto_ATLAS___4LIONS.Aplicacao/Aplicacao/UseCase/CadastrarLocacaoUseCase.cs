using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarLocacaoUseCase : ICadastrarLocacaoUseCase
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public CadastrarLocacaoUseCase(
            ILocacaoRepositorio locacaoRepositorio,
            ITabelaPrecoRepositorio tabelaPrecoRepositorio,
            IAutomovelRepositorio automovelRepositorio,
            IPessoaRepositorio pessoaRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
        }

        public int Executar(LocacaoDTO locacaoDto)
        {



            // Buscar o automóvel completo para obter o ID do preço
            var automovelDto = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel)
                ?? throw new Exception("Automóvel não encontrado.");

            //  Buscar o preço da diária do automóvel
            var precoDiaria = _tabelaPrecoRepositorio.RecuperarPorId(automovelDto.IdPreco ?? 0)?.Valor
                ?? throw new Exception("Preço da diária não encontrado para o automóvel selecionado.");

            //  Buscar o Locatário e o Condutor completos
            var locatarioDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario)
                ?? throw new Exception("Locatário não encontrado.");

            var condutorDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdCondutor)
                ?? throw new Exception("Condutor não encontrado.");

            // . Calcular o valor total da locação
            locacaoDto.ValorTotal = CalcularValorTotal(locacaoDto.Saida, locacaoDto.Retorno, precoDiaria);

            // Criar a entidade Locacao com os objetos COMPLETOS
            var locacao = new Locacao(
                locacaoDto.Saida,
                locacaoDto.Retorno,
                locacaoDto.TipoLocacao,
                locacaoDto.ValorTotal,
                new Pessoa
                {
                    Id = locatarioDto.Id,
                    Nome = locatarioDto.Nome,
                    Email = locatarioDto.Email,
                    Contato = locatarioDto.Contato,
                    Cpf = locatarioDto.Cpf,
                    Cnpj = locatarioDto.Cnpj,
                    DataNascimento = locatarioDto.DataNascimento,
                    NumeroCnh = locatarioDto.NumeroCnh,
                    VencimentoCnh = locatarioDto.VencimentoCnh
                },
                new Pessoa
                {
                    Id = condutorDto.Id,
                    Nome = condutorDto.Nome,
                    Email = condutorDto.Email,
                    Contato = condutorDto.Contato,
                    Cpf = condutorDto.Cpf,
                    Cnpj = condutorDto.Cnpj,
                    DataNascimento = condutorDto.DataNascimento,
                    NumeroCnh = condutorDto.NumeroCnh,
                    VencimentoCnh = condutorDto.VencimentoCnh
                },
                new Automovel
                {
                    Id = automovelDto.Id,
                    Modelo = automovelDto.Modelo,
                    Placa = automovelDto.Placa,
                    Cor = automovelDto.Cor,
                    Chassi = automovelDto.Chassi,
                    Renavam = automovelDto.Renavam,
                    Oleokm = automovelDto.Oleokm,
                    PastilhaFreioKm = automovelDto.PastilhaFreioKm,
                    DataCriacao = automovelDto.DataCriacao,
                    Status = automovelDto.Status,
                },
                EStatusLocacao.ANDAMENTO

        );

            try
            { 
                if (!locacao.Validacao())
                    throw new Exception("A locação não passou na validação de regras de negócio.");
                _automovelRepositorio.AtualizarStatus(locacao.Automovel.Id, EStatusVeiculo.ALUGADO);
                return _locacaoRepositorio.Adicionar(locacaoDto);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }

        public decimal CalcularValorTotal(DateTime saida, DateTime retorno, decimal precoDiaria)
        {
            int dias = (retorno - saida).Days;
            return dias > 0 ? dias * precoDiaria : precoDiaria; // Se for um único dia, cobra pelo menos uma diária
        }
    }
}
