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
            var locacaorepositorio = new LocacaoRepositorio();
            var pagamentoRepositorio = new PagamentoRepositorio();
            var parcelaRepositorio = new ParcelaRepositorio();
            var pendenciaRepositorio = new PendenciaFinanceiraRepositorio();
            var useCaseListarPessoa = new ListarPessoaUseCase(pessoaRepositorio);
            var useCaseListarAutomovel = new ListarAutomovelUseCase(automovelRepositorio);
            var useCaseAdicionarLocacao = new CadastrarLocacaoUseCase(locacaorepositorio);
            var useCasePersistirPag = new PersistirPagamentoUseCase(pagamentoRepositorio);

            useCaseListarPessoa.ExecutarDadosBreves();
            Console.WriteLine();
            Console.Write("Selecione o Id do locatário: ");
            int escolhaLocatario = int.Parse(Console.ReadLine());
            var locatario = pessoaRepositorio.RecuperarPor(a => a.Id == escolhaLocatario);
            Console.Clear();
            useCaseListarPessoa.ExecutarDadosBreves();
            Console.WriteLine();
            Console.Write("Selecione o Id do condutor do veículo: ");
            int escolhaCondutor = int.Parse(Console.ReadLine());
            var condutor = pessoaRepositorio.RecuperarPor(a => a.Id == escolhaCondutor);

            Console.Write("Digite o numero da CNH definitiva/provisória: ");
            string numeroCnh = Console.ReadLine();
            Console.Write("Vencimento CNH definitiva/provisória: (dd/MM/yyyy): ");
            DateTime vencimento = DateTime.Parse(Console.ReadLine());
            CnhValidaDTO cnh = new CnhValidaDTO(numeroCnh, vencimento);

            Console.Clear();
            useCaseListarAutomovel.ExecutarDadosBreves();
            Console.WriteLine();
            Console.Write("Selecione o ID do automovel que será locado:  ");
            int escolhaAutomovel = int.Parse(Console.ReadLine());
            var automovel = automovelRepositorio.RecuperarPor(a => a.Id == escolhaAutomovel);
            automovel.Status = EStatusVeiculo.ALUGADO;

            var tipoLocacao = DefinirContratoLocacao.Definir();
            var especie = MenuEspecie.Exibir();
            var parcelas = MenuParcelas.Exibir(tipoLocacao, especie);

            Console.Write("Informe a data saída (dd/MM/yyyy): ");
            DateTime saida = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe a data retorno (dd/MM/yyyy): ");
            DateTime retorno = DateTime.Parse(Console.ReadLine());
            decimal valorTotal = CalcularPrecoServico.CalcularPreco(tipoLocacao, automovel.ValorDiaria);
            Console.WriteLine(valorTotal);
            var pagamento = new PagamentoDTO(especie, valorTotal, DateTime.Now);
            useCasePersistirPag.Executar(pagamento);
            var locacao = new LocacaoDTO(saida, retorno, tipoLocacao, Guid.NewGuid(), valorTotal, locatario.Id, condutor.Id, automovel.Id, pagamento.Id);
            var useCasePersistirPendFin = new PersistirPendenciaFinanceiraUseCase(pendenciaRepositorio, parcelaRepositorio,locacao);
            var pendfin = LançarPendenciaFinanceira.GerarPendencia(valorTotal,parcelas,saida,tipoLocacao,locacao);
            useCaseAdicionarLocacao.Executar(locacao);
            pendfin.LocacaoId = locacao.Id;
            useCasePersistirPendFin.Executar(pendfin);
        }
    }
}
