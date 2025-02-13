using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroLocacao
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IParcelaRepositorio _parcelaRepositorio;
        private readonly IPendenciaFinanceiraRepositorio _pendenciaFinanceiraRepositorio;

        public CadastroLocacao(ILocacaoRepositorio locacaoRepositorio, IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio tabelaPrecoRepositorio, IParcelaRepositorio parcelaRepositorio, IPendenciaFinanceiraRepositorio pendenciaFinanceiraRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _parcelaRepositorio = parcelaRepositorio;
            _pendenciaFinanceiraRepositorio = pendenciaFinanceiraRepositorio;
        }
        public void Cadastrar()
        {
            Console.Clear();
            var useCaseListarPessoa = new ListarPessoaUseCase(_pessoaRepositorio);
            var useCaseListarPendenciaFinanceira = new ListarPendenciaFinanceiraUseCase(_pendenciaFinanceiraRepositorio);
            var useCaseListarAutomovel = new ListarAutomovelUseCase(_automovelRepositorio);
            var useCaseListarPrecos = new ListarTabelaPrecoUseCase(_tabelaPrecoRepositorio);
            var useCaseCadastrarParcela = new CadastrarParcelaUseCase(_parcelaRepositorio);
            var useCaseCadastrarPendfin = new CadastrarPendenciaFinanceiraUseCase(_pendenciaFinanceiraRepositorio);
            var useCaseCdastrarLocacao = new CadastrarLocacaoUseCase(_locacaoRepositorio,_pessoaRepositorio,_automovelRepositorio,_pendenciaFinanceiraRepositorio);
            var UseCaseAlterarStatusVeiculo = new AlterarStatusVeiculoUseCase(_automovelRepositorio);
            var locatarioDto = DefinirLocatario.Definir(_pessoaRepositorio, useCaseListarPessoa);
            var condutorDto = DefinirCondutor.Definir(_pessoaRepositorio, useCaseListarPessoa);


            Console.Clear();
            int escolhaPreco = 0;
            do
            {

                var automovelDto = DefinirAutomovel.Definir(_automovelRepositorio, useCaseListarAutomovel);

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

                decimal valorParcela = Math.Floor(valorTotal / n);

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

                LocacaoDTO locacaoDto = new LocacaoDTO(saida, retorno, tipoLocacao, valorTotal, locatario.Id, condutor.Id, automovel.Id)
                {
                    Status = Dominio.ValueObjects.Enums.EStatusLocacao.ANDAMENTO
                };

                UseCaseAlterarStatusVeiculo.Executar(automovel.Id, automovel.Status);
               
                var pendenciaDto = new PendenciaFinanceiraDTO
                {
                    TransacaoId = Guid.NewGuid(),
                    ValorTotal = valorTotal,
                    DataCriacao = DateTime.Now,
                    IdLocacao = useCaseCdastrarLocacao.Executar(locacaoDto),
                };

                useCaseCadastrarPendfin.Executar(pendenciaDto);

                for (int i = 1; i <= n; i++)
                {                    var parcela = new Parcela
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
            MenuInicial menuInicial = new MenuInicial();
            menuInicial.Exibir();
        }

    }
}
