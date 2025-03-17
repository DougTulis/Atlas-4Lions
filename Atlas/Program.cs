using Microsoft.Extensions.DependencyInjection;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using Projeto_ATLAS___4LIONS.Forms;
using System;
using System.Windows.Forms;
using Atlas;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Infra.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceProvider = ConfigureServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = serviceProvider.GetRequiredService<FrmPrincipal>();
            Application.Run(mainForm);
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            // Repositrios
            services.AddSingleton<IPessoaRepositorio, PessoaRepositorio>();
            services.AddSingleton<IAutomovelRepositorio, AutomovelRepositorio>();
            services.AddSingleton<ITabelaPrecoRepositorio, TabelaPrecoRepositorio>();
            services.AddSingleton<ILocacaoRepositorio, LocacaoRepositorio>();
            services.AddSingleton<IPendenciaFinanceiraRepositorio, PendenciaFinanceiraRepositorio>();
            services.AddSingleton<IParcelaRepositorio, ParcelasRepositorio>();



            // Use Cases
            services.AddTransient<IIncluirPagamentoUseCase, IncluirPagamentoUseCase>();
            services.AddTransient<ICadastrarLocacaoPendFinParcelaUseCase, CadastrarLocacaoPendFinParcelaUseCase>();
            services.AddTransient<IAlterarStatusVeiculoUseCase, AlterarStatusVeiculoUseCase>();
            services.AddTransient<IAlterarStatusLocacaoUseCase, AlterarStatusLocacaoUseCase>();
            services.AddTransient<IListarParcelaUseCase, ListarParcelaUseCase>();
            services.AddTransient<IListarPendenciaFinanceiraUseCase, ListarPendenciaFinanceiraUseCase>();
            services.AddTransient<IDeletarAutomovelUseCase, DeletarAutomovelUseCase>();
            services.AddTransient<IIncluirCnhUseCase, IncluirCnhUseCase>();
            services.AddTransient<IDeletarPessoaUseCase, DeletarPessoaUseCase> ();
            services.AddTransient<IListarPessoaUseCase, ListarPessoaUseCase>();
            services.AddTransient<ICadastrarPessoaUseCase, CadastrarPessoaUseCase>();
            services.AddTransient<ICadastrarVeiculoUseCase, CadastrarVeiculoUseCase>();
            services.AddTransient<ICadastrarTabelaPrecoUseCase, CadastrarPrecoAutomovelUseCase>();
            services.AddTransient<IListarAutomovelUseCase, ListarAutomovelUseCase>();
            services.AddTransient<IListarTabelaPrecoUseCase, ListarTabelaPrecoUseCase>();
            services.AddTransient<IListarHistoricoLocacaoUseCase, ListarHistoricoLocacaoUseCase>();

            // Forms
            services.AddScoped<FrmPrincipal>();
            services.AddSingleton<IMySqlAdaptadorConexao, MySqlAdaptadorConexao>();

            services.AddTransient<FrmCadPessoas>();
            services.AddTransient<FrmCadAutomovel>();
            services.AddTransient<FrmCadLocacao>();
            services.AddTransient<FrmHistoricoPessoas>();
            services.AddTransient<FrmExclusaoPessoas>();
            services.AddTransient<FrmVinculacaoCnh>();
            services.AddTransient<FrmHistoricoAutomovel>();
            services.AddTransient<FrmExclusaoAutomovel>();
            services.AddTransient<FrmHistoricoLocacao>();
            services.AddTransient<FrmBaixaLocacao>();
            services.AddTransient<FrmRegistroPagamento>();
            services.AddTransient<FrmCadastroPreco>();


            services.AddTransient<ICalculoValorLocacaoService, CalculoValorLocacaoService>();
            services.AddTransient<IPendenciaFinanceiraService, PendenciaFinanceiraService>();
            services.AddTransient<IParcelaService, ParcelaService>();

            return services.BuildServiceProvider();
        }
    }
}
