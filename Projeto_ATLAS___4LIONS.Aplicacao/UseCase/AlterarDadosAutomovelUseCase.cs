using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class AlterarDadosAutomovelUseCase : IAlterarDadosAutomovelUseCase
    {

        private readonly IAutomovelRepositorio _automovelRepositorio;

        public AlterarDadosAutomovelUseCase(IAutomovelRepositorio automovelRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
        }

        public RespostaPadrao<string> Executar<T>(AutomovelDTO automovelDto, string campoBanco, string campoSelecionado, T dados)
        {

            var automovel = Automovel.CreateFromDataBase(automovelDto.Id,
                automovelDto.DataCriacao,
                automovelDto.Modelo,
                automovelDto.Placa,
                automovelDto.Cor,
                automovelDto.Status,
                automovelDto.Ano,
                automovelDto.Chassi,
                automovelDto.Renavam,
                automovelDto.Oleokm,
                automovelDto.PastilhaFreioKm,
                automovelDto.IdPreco
                );

            switch (campoBanco)
            {
                case "modelo":
                    automovel.AlterarModelo(dados.ToString());
                    break;
                case "placa":
                    automovel.AlterarPlaca(dados.ToString());

                    if (_automovelRepositorio.PlacaExiste(automovel.Placa))
                    {
                        return RespostaPadrao<string>.Falha(false, "Cadastro de automóveis", "Placa já cadastrada");
                    }
                    break;
                case "cor":
                    automovel.AlterarCor(dados.ToString());
                    break;
                case "chassi":
                    automovel.AlterarChassi(dados.ToString());
                    break;
                case "oleo_km":
                    automovel.AlterarOleoKm(Convert.ToInt16(dados));
                    break;
                case "renavam":
                    automovel.AlterarOleoKm(Convert.ToInt16(dados));
                    break;
                case "pastilha_freio_km":
                    automovel.AlterarPastilhaKm(Convert.ToInt16(dados));
                    break;
                case "ano":
                    automovel.AlterarAno(dados.ToString());
                    break;
            }
            try
            {

                string erros;
                if (!automovel.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Edição de automóveis", erros);
                }

                _automovelRepositorio.AtualizarDados(automovel.Id, campoBanco, dados);
                return RespostaPadrao<string>.Sucesso(true, "Edição de automóveis", campoSelecionado + " atualizado com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }
    }
}
