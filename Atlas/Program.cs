using System;
using System.Windows.Forms;
using Atlas;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Forms;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var pessoaRepositorio = new PessoaRepositorio();
            var automovelRepositorio = new AutomovelRepositorio();
            var locacaoRepositorio = new LocacaoRepositorio(pessoaRepositorio, automovelRepositorio);
            var tabelaPrecoRepositorio = new TabelaPrecoRepositorio();
            var pendenciaFinanceiraRepositorio = new PendenciaFinanceiraRepositorio(locacaoRepositorio);
            var parcelaRepositorio = new ParcelaRepositorio();

            var listarPessoaUseCase = new ListarPessoaUseCase(pessoaRepositorio);
            var listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);
            var cadastrarLocacaoUseCase = new CadastrarLocacaoUseCase(locacaoRepositorio,tabelaPrecoRepositorio,automovelRepositorio, pessoaRepositorio);
            var listarHistoricoLocacaoUseCase = new ListarHistoricoLocacaoUseCase(locacaoRepositorio, pessoaRepositorio);

            var locacaoService = new LocacaoService(cadastrarLocacaoUseCase,tabelaPrecoRepositorio); 

            var pendenciaFinanceiraService = new PendenciaFinanceiraServico(
                pendenciaFinanceiraRepositorio, parcelaRepositorio, tabelaPrecoRepositorio
            );

            // 🔹 Criando Formulário e passando os serviços via construtor
            var frmCadLocacao = new FrmCadLocacao(
                locacaoService,
                pendenciaFinanceiraService,
                listarPessoaUseCase,
                listarAutomovelUseCase,
                tabelaPrecoRepositorio
            );

            Application.Run(new FrmPrincipal(locacaoService, pendenciaFinanceiraService,listarPessoaUseCase,listarAutomovelUseCase,listarHistoricoLocacaoUseCase,pessoaRepositorio,automovelRepositorio,tabelaPrecoRepositorio));

        }
    }
}
