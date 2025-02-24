using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
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
        public void Executar(LocacaoDTO locacaoDto)
        {
            //  Buscar o Locatario e fabrica o model
            var locatarioDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);
            var locatario = Pessoa.Create(locatarioDto.Nome, locatarioDto.Email, locatarioDto.Contato, locatarioDto.TipoPessoa, locatarioDto.NumeroDocumento, locatarioDto.DataRegistro);

            //  Buscar o CondutorDto e fabrica o model
            var condutorDto = _pessoaRepositorio.RecuperarPorId(locacaoDto.IdLocatario);
            var condutor = Pessoa.Create(condutorDto.Nome, condutorDto.Email, condutorDto.Contato, condutorDto.TipoPessoa, condutorDto.NumeroDocumento, condutorDto.DataRegistro);

            // Buscar o automóvel, preco por id e fabrica o model de ambos
            var automovelDto = _automovelRepositorio.RecuperarPorId(locacaoDto.IdAutomovel);
            var precoDto = _tabelaPrecoRepositorio.RecuperarPorId(automovelDto.IdPreco);
            var preco = TabelaPreco.Create(precoDto.Descricao, precoDto.Valor);
            var automovel = Automovel.Create(automovelDto.Modelo, automovelDto.Placa, automovelDto.Cor, automovelDto.Status, automovelDto.Ano, automovelDto.Chassi, automovelDto.Renavam, automovelDto.Oleokm, automovelDto.PastilhaFreioKm, preco);

            //servico q calculo o valor total
            var valorTotal = CalculoValorLocacaoService.CalcularValorTotal(locacaoDto.Saida, locacaoDto.Retorno, preco.Valor);


            var locacao = Locacao.Create(locacaoDto.Saida, locacaoDto.Retorno, locacaoDto.TipoLocacao, locatario, condutor, automovel, locacaoDto.Status,valorTotal);


            if (!locacao.Validacao())
            {
                throw new Exception("A locação não passou na validação de regras de negócio.");
            }

          //  var pendenciaFinanceira = PendenciaFinanceira.Create(locacao.ValorTotal);

        //    if (!pendenciaFinanceira.Validacao())
            {
                throw new Exception("A pendência financeira não passou na validação.");
            }

          //  locacao.AdicionarPendenciaFinanceira(pendenciaFinanceira);
            try
            {
                // 🔹 5️⃣ Atualizar Status do Automóvel
                _automovelRepositorio.AtualizarStatus(automovel.Id, EStatusVeiculo.ALUGADO);

                // 🔹 6️⃣ Persistir a Locacao no banco
                _locacaoRepositorio.Adicionar(locacao);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}

