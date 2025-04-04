﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPrecoAutomovelUseCase : ICadastrarTabelaPrecoUseCase
    {
        private readonly ITabelaPrecoRepositorio tabelaRepositorio;
        public CadastrarPrecoAutomovelUseCase(ITabelaPrecoRepositorio tabelaRepositorio)
        {
            this.tabelaRepositorio = tabelaRepositorio;
        }
        public RespostaPadrao<string> Executar(TabelaPrecoDTO tabelaPrecoDto)
        {
            try
            {
                var tabelaPreco = TabelaPreco.Create(tabelaPrecoDto.Descricao, tabelaPrecoDto.Valor);

                if (!tabelaPreco.Validacao(out string erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Cadastro de preço", erros);

                }
                return RespostaPadrao<string>.Sucesso(true, "Cadastro de preço", "Preço cadastrado com sucesso!");
                tabelaRepositorio.Adicionar(tabelaPreco);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
