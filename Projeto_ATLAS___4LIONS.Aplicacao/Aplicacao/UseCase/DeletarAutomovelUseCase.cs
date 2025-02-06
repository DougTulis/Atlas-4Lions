using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class DeletarAutomovelUseCase
    {
        private readonly IAutomovelRepositorio automovelRepositorio;
        public DeletarAutomovelUseCase(IAutomovelRepositorio automovelRepositorio)
        {
            this.automovelRepositorio = automovelRepositorio;
        }
        public void Executar(AutomovelDTO automovelDto)
        {
            try
            {
                var automovel = new Automovel
                {
                    Id = automovelDto.Id,
                    Modelo = automovelDto.Modelo,
                    Placa = automovelDto.Placa,
                    Cor = automovelDto.Cor,
                    Status = automovelDto.Status,
                    Chassi = automovelDto.Chassi,
                    Renavam = automovelDto.Renavam,
                    Oleokm = automovelDto.Oleokm,
                    DataCriacao = automovelDto.DataCriacao,
                    PastilhaFreioKm = automovelDto.PastilhaFreioKm

                };

                if (!automovel.ValidarPraDeletar())
                {
                    Thread.Sleep(2000);
                    MenuInicial menuInicial = new MenuInicial();
                    menuInicial.Exibir();
                }
                automovelRepositorio.Deletar(automovelDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
