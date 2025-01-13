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
                var status = EStatusVeiculo.GARAGEM;

                Console.Write("Chassi (campo não obrigatório): ");
                string? chassi = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : Console.ReadLine();
                Console.Write("Reanavan (campo não obrigatório): ");
                string? renavam = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : Console.ReadLine();
                Console.Write("Quilometragem da última troca de óleo (Não obrigatório): ");
                int? oleoKm = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : int.Parse(Console.ReadLine()); ;
                Console.Write("Informe a quilometragem da última troca das pastilhas de freio(km) (Não obrigatório): ");
                int? pastilhaFreioKm = string.IsNullOrWhiteSpace(Console.ReadLine()) ? null : int.Parse(Console.ReadLine());
                var automovel = new AutomovelDTO(modelo, placa, cor, status, chassi, renavam, oleoKm, pastilhaFreioKm);

                var automovelRepositorio = new AutomovelRepositorio();
                var useCaseAdicionarAutomovel = new CadastrarVeiculoUseCase(automovelRepositorio);
                useCaseAdicionarAutomovel.Executar(automovel);

       
                int automovelId = automovel.Id;

                var listaPreco = DefinirPrecos.Definir(automovelId);
                var tabelaPrecoRepositorio = new TabelaPrecoRepositorio();
                var cadastrarPrecoUseCase = new CadastrarPrecoAutomovelUseCase(tabelaPrecoRepositorio);

                foreach (var preco in listaPreco)
                {
                    var tabelaPrecoDTO = new TabelaPrecoDTO(preco.Descricao, preco.Valor, automovel.Id);
                    cadastrarPrecoUseCase.Executar(tabelaPrecoDTO);
                }
          
               // Veiculo cadastrado
                Thread.Sleep(2500);
                Console.Clear();
                SubMenuVeiculos.Exibir();
            }
            catch (FormatException ex) { Console.WriteLine(ex.StackTrace); }

        }
    }
}
