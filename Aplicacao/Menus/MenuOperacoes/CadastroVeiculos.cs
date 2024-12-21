using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroVeiculos
    {

        public static void Cadastrar()
        {
            try
            {
                Console.Clear();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Ano: ");
                string ano = Console.ReadLine();
                Console.Write("Cor: ");
                string cor = Console.ReadLine();
                Console.Write("Placa: ");
                string placa = Console.ReadLine();
                Console.WriteLine(" Selecione o Status inicial do automóvel: ");
                Console.WriteLine("1. GARAGEM");
                Console.WriteLine("2. ALUGADO");
                var status = (EStatusVeiculo)int.Parse(Console.ReadLine());
                Console.Write("Valor Diária: ");
                decimal valorDiaria = decimal.Parse(Console.ReadLine());
                Console.Write("Chassi (campo não obrigatório): ");
                string? chassi = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null :Console.ReadLine();
                Console.Write("Reanavan (campo não obrigatório): ");
                string? renavam = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : Console.ReadLine();
                Console.Write("Quilometragem da última troca de óleo (Não obrigatório): ");
                int? oleoKm = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : int.Parse(Console.ReadLine()); ;
                Console.Write("Informe a quilometragem da última troca das pastilhas de freio(km) (Não obrigatório): ");
                int? pastilhaFreioKm = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : int.Parse(Console.ReadLine());
                var automovel = new AutomovelDTO(modelo, placa, cor, status, valorDiaria, chassi, renavam, oleoKm, pastilhaFreioKm);
                var automovelRepositorio = new AutomovelRepositorio();
                var useCase = new CadastrarVeiculoUseCase(automovelRepositorio);
                useCase.Executar(automovel);
                Console.WriteLine("Veículo CadastradO com sucesso... Voltando ao menu principal");
                Thread.Sleep(2500);
                Console.Clear();
                MenuInicial.Exibir();
            }
            catch (MySqlException ex) { Console.WriteLine(ex.StackTrace); }
            catch (FormatException ex) { Console.WriteLine(ex.StackTrace); }






        }
    }
}
