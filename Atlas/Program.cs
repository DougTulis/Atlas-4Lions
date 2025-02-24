using Microsoft.Extensions.DependencyInjection;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using Projeto_ATLAS___4LIONS.Forms;
using System;
using System.Windows.Forms;
using Atlas;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Servicos;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;

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



            // Use Cases
            services.AddTransient<IAlterarStatusVeiculoUseCase, AlterarStatusVeiculoUseCase>();
            services.AddTransient<IAlterarStatusLocacaoUseCase, AlterarStatusLocacaoUseCase>();
            services.AddTransient<IListarLocacoesUseCase, ListarLocacoesUseCase>();
            services.AddTransient<IListarParcelaUseCase, ListarParcelaUseCase>();
            services.AddTransient<IListarPendenciaFinanceiraUseCase, ListarPendenciaFinanceiraUseCase>();
            services.AddTransient<IDeletarAutomovelUseCase, DeletarAutomovelUseCase>();
            services.AddTransient<IIncluirCnhUseCase, IncluirCnhUseCase>();
            services.AddTransient<IDeletarPessoaUseCase, DeletarPessoaUseCase> ();
            services.AddTransient<IListarPessoaUseCase, ListarPessoaUseCase>();
            services.AddTransient<ICadastrarPessoaUseCase, CadastrarPessoaUseCase>();
            services.AddTransient<ICadastrarVeiculoUseCase, CadastrarVeiculoUseCase>();
            services.AddTransient<ICadastrarLocacaoUseCase, CadastrarLocacaoUseCase>();
            services.AddTransient<ICadastrarTabelaPrecoUseCase, CadastrarPrecoAutomovelUseCase>();
            services.AddTransient<IListarAutomovelUseCase, ListarAutomovelUseCase>();
            services.AddTransient<IListarTabelaPrecoUseCase, ListarTabelaPrecoUseCase>();
            services.AddTransient<IListarHistoricoLocacaoUseCase, ListarHistoricoLocacaoUseCase>();

            // Forms
            services.AddTransient<FrmCadastroPreco>();
            services.AddTransient<FrmPrincipal>();
            services.AddTransient<FrmBaixaLocacao>();
            services.AddTransient<FrmCadAutomovel>();
            services.AddTransient<FrmCadLocacao>();
            services.AddTransient<FrmCadPessoas>();
            services.AddTransient<FrmExclusaoAutomovel>();
            services.AddTransient<FrmExclusaoPessoas>();
            services.AddTransient<FrmHistoricoAutomovel>();
            services.AddTransient<FrmHistoricoLocacao>();
            services.AddTransient<FrmHistoricoPessoas>();
            services.AddTransient<FrmRegistroPagamento>();
            services.AddTransient<FrmRegistroPagamento2>();
            services.AddTransient<FrmVinculacaoCnh>();

            services.AddSingleton<IMySqlAdaptadorConexao, MySqlAdaptadorConexao>();


            return services.BuildServiceProvider();
        }
    }
}
