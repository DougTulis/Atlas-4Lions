﻿using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface
{
    public interface IDevolverAutomovelEncerrarLocUseCase
    {
        public RespostaPadrao<string> ExecutarDevolucaoAutomovel(Guid automovelId, Guid locacaoId);

    }
}
