using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

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
            var UseCaseAlterarStatusVeiculo = new AlterarStatusVeiculoUseCase(automovelRepositorio);


            var locatarioDto = DefinirLocatario.Definir(pessoaRepositorio, useCaseListarPessoa);

            var condutorDto = DefinirCondutor.Definir(pessoaRepositorio, useCaseListarPessoa);

            Console.Clear();
            int escolhaPreco = 0;
            do
            {

                var automovelDto = DefinirAutomovel.Definir(automovelRepositorio, useCaseListarAutomovel);

                Console.WriteLine("\nTabela de Preços para este Automóvel:");
                useCaseListarPrecos.ExecutarRecuperarPorId(automovelDto.Id);
                Console.WriteLine("Deseja continuar? ");
                Console.WriteLine("1. Sim");
                Console.WriteLine("0. Não");
                escolhaPreco = int.Parse(Console.ReadLine());
      
                if (escolhaPreco == 0) continue;
                TabelaPrecoDTO tabelaPreco = useCaseListarPrecos.ExecutarRecuperarPorId(automovelDto.Id);

                var tipoLocacao = DefinirContratoLocacao.Definir();

                Console.Write("Informe a data saída (dd/MM/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());
                Console.Write("Informe a data retorno (dd/MM/yyyy): ");
                DateTime retorno = DateTime.Parse(Console.ReadLine());
                TimeSpan periodo = retorno.Subtract(saida);

                int n = 0;
                if (tipoLocacao == Dominio.ValueObjects.Enums.ETipoLocacao.CONTRATO)
                {
                    Console.Write("Quantidade de parcelas: ");
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    n = 1;
                }
                decimal valorTotal = periodo.Days * tabelaPreco.Valor;

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
                automovel.AlterarParaAlugado();


                UseCaseAlterarStatusVeiculo.Executar(automovel.Id,automovel.Status);
                
                var pendencia = new PendenciaFinanceira(Guid.NewGuid(), valorTotal);

                var pendenciaDto = new PendenciaFinanceiraDTO
                {

                    TransacaoId = pendencia.TransacaoId,
                    ValorTotal = pendencia.ValorTotal,
                    DataCriacao = pendencia.DataCriacao,

                };
                useCaseCadastrarPendfin.Executar(pendenciaDto);

                pendencia.Id = pendenciaDto.Id;
        
                LocacaoDTO locacaoDto = new LocacaoDTO(saida, retorno, tipoLocacao, valorTotal, locatario, condutor, automovel, pendencia)
                {
                    Status = Dominio.ValueObjects.Enums.EStatusLocacao.ANDAMENTO
                };

                useCaseCdastrarLocacao.Executar(locacaoDto);

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

            } while (escolhaPreco == 0);
            MenuInicial.Exibir();
        }

    }
}
