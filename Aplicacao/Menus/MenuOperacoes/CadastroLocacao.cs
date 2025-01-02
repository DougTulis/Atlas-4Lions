using Org.BouncyCastle.Asn1.Pkcs;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroLocacao
    {
        public static void Cadastrar()
        {
            Console.Clear();
            var pessoaRepositorio = new PessoaRepositorio();
            var automovelRepositorio = new AutomovelRepositorio();
            var precoRepositorio = new TabelaPrecoRepositorio();
            var parcelaRepositorio = new ParcelaRepositorio();
            var pendfinRepositorio = new PendenciaFinanceiraRepositorio();
            var locacaoRepositorio = new LocacaoRepositorio();
            var useCaseListarPessoa = new ListarPessoaUseCase(pessoaRepositorio);
            var useCaseListarAutomovel = new ListarAutomovelUseCase(automovelRepositorio);
            var useCaseListarPrecos = new ListarTabelaPrecoUseCase(precoRepositorio);
            var useCaseCadastrarParcela = new CadastrarParcelaUseCase(parcelaRepositorio);
            var useCaseCadastrarPendfin = new CadastrarPendenciaFinanceiraUseCase(pendfinRepositorio);
            var useCaseCdastrarLocacao = new CadastrarLocacaoUseCase(locacaoRepositorio);


            var locatarioDto = DefinirLocatario.Definir(pessoaRepositorio, useCaseListarPessoa);

            Console.Clear();
            useCaseListarPessoa.ExecutarDadosBreves();
            Console.WriteLine();
            Console.Write("Selecione o Id do condutor do veículo: ");
            int escolhaCondutor = int.Parse(Console.ReadLine());
            var condutorDto = pessoaRepositorio.RecuperarPor(a => a.Id == escolhaCondutor);

            Console.Clear();
            int escolhaPreco = 0;
            do
            {
                useCaseListarAutomovel.ExecutarDadosBreves();
                Console.WriteLine();
                Console.Write("Selecione o ID do automovel que será locado:  ");
                int escolhaAutomovel = int.Parse(Console.ReadLine());
                var automovelDto = automovelRepositorio.RecuperarPor(a => a.Id == escolhaAutomovel);

                Console.WriteLine("\nTabela de Preços para este Automóvel:");
                useCaseListarPrecos.ExecutarListarPor(a => a.AutomovelId == automovelDto.Id);
                Console.Write("Selecione o preço: (ou Digite 0 para optar outro veículo): ");
                escolhaPreco = int.Parse(Console.ReadLine());
                TabelaPrecoDTO tabelaPreco = useCaseListarPrecos.ExecutarRecuperarPor(a => a.Id == escolhaPreco);
                automovelDto.Status = EStatusVeiculo.ALUGADO;

                if (escolhaPreco == 0) continue;

                var tipoLocacao = DefinirContratoLocacao.Definir();

                Console.Write("Quantidade de parcelas: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Informe a data saída (dd/MM/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());
                Console.Write("Informe a data retorno (dd/MM/yyyy): ");
                DateTime retorno = DateTime.Parse(Console.ReadLine());
                TimeSpan periodo = retorno.Subtract(saida);

                decimal valorTotal = CalcularValor(periodo.Days, tabelaPreco.Valor);
                decimal valorParcela = Math.Round(valorTotal / n, 2);

                var locatario = new Pessoa
                {
                    Id = locatarioDto.Id,
                    Contato = locatarioDto.Contato,
                    Cpf = locatarioDto.Cpf,
                    Nome = locatarioDto.Nome,
                    Email = locatarioDto.Email,
                    DataNascimento = locatarioDto.DataNascimento,
                    DataCriacao = locatarioDto.DataCriacao,
                    NumeroCnh = locatarioDto.NumeroCnh,
                    VencimentoCnh = locatarioDto.VencimentoCnh,
                };


                var condutor = new Pessoa
                {
                    Id = condutorDto.Id,
                    Contato = condutorDto.Contato,
                    Cpf = condutorDto.Cpf,
                    Nome = condutorDto.Nome,
                    Email = condutorDto.Email,
                    DataNascimento = condutorDto.DataNascimento,
                    VencimentoCnh = condutorDto.VencimentoCnh,
                    NumeroCnh = condutorDto.NumeroCnh,
                    DataCriacao = condutorDto.DataCriacao,
                };



                var automovel = new Automovel
                {
                    Id = automovelDto.Id,
                    Status = automovelDto.Status,
                    Cor = automovelDto.Cor,
                    Chassi = automovelDto.Chassi,
                    Modelo = automovelDto.Modelo,
                    DataCriacao = automovelDto.DataCriacao,
                    PastilhaFreioKm = automovelDto.PastilhaFreioKm,
                    Oleokm = automovelDto.Oleokm,
                    Placa = automovelDto.Placa,
                    Renavam = automovelDto.Renavam,
                    TabelaPrecos = automovelDto.TabelaPrecos
                };
                Guid guid = Guid.NewGuid();
                var pendencia = new PendenciaFinanceira(guid, valorTotal);

                var pendenciaDto = new PendenciaFinanceiraDTO
                {

                    TransacaoId = pendencia.TransacaoId,
                    ValorTotal = pendencia.ValorTotal,
                    DataCriacao = pendencia.DataCriacao,

                };

                pendencia.Id = pendenciaDto.Id;

                LocacaoDTO locacaoDto = new LocacaoDTO(saida, retorno, tipoLocacao, valorTotal, locatario, condutor, automovel, pendencia);

                useCaseCdastrarLocacao.Executar(locacaoDto);
                useCaseCadastrarPendfin.Executar(pendenciaDto);

                for (int i = 1; i <= n; i++)
                {
                    var parcela = new Parcela
                    {
                        Sequencia = i,
                        Valor = valorParcela,
                        DataVencimento = DateTime.Now.AddMonths(i - 1),

                    };

                    var parcelaDto = new ParcelaDTO
                    {
                        Sequencia = parcela.Sequencia,
                        Valor = parcela.Valor,
                        DataVencimento = parcela.DataVencimento,
                        PendenciaFinanceiraId = pendenciaDto.Id
                    };
                    useCaseCadastrarParcela.Executar(parcelaDto);
                }
                break;

                decimal CalcularValor(int dias, decimal valorAutomovel)
                {
                    return valorAutomovel * dias;
                }
            } while (escolhaPreco == 0);
            MenuInicial.Exibir();
        }

    }
}
