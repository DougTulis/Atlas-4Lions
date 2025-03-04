
using Microsoft.OpenApi.Models;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS_4LIONS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                 .AddJsonOptions(options =>
                 {
                     options.JsonSerializerOptions.WriteIndented = true;
                     options.JsonSerializerOptions.PropertyNamingPolicy = null;
                 });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1",new OpenApiInfo
            {
                Title = "API - ATLAS",
                Version = "v1",
                Description = "API projeto ATLAS"
            }));

            //conteiner di
            builder.Services.AddScoped<IListarPessoaUseCase, ListarPessoaUseCase>();
            builder.Services.AddScoped<IPessoaRepositorio, PessoaRepositorio>();
            builder.Services.AddScoped<IMySqlAdaptadorConexao, MySqlAdaptadorConexao>();
            builder.Services.AddScoped<ICadastrarPessoaUseCase, CadastrarPessoaUseCase>();
            builder.Services.AddScoped<IIncluirCnhUseCase, IncluirCnhUseCase>();
            builder.Services.AddScoped<IDeletarPessoaUseCase, DeletarPessoaUseCase>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1"));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
