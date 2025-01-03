﻿using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarVeiculoUseCase
    {
        private readonly ICrud<AutomovelDTO> automovelRepositorio;
        public CadastrarVeiculoUseCase(ICrud<AutomovelDTO> automovelRepositorio)
        {
            this.automovelRepositorio = automovelRepositorio;
        }

        public void Executar(AutomovelDTO _automovel)
        {

            automovelRepositorio.Adicionar(_automovel);

        }

    }
}
