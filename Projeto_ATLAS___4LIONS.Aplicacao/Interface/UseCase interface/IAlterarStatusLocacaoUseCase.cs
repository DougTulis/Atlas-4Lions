﻿using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface
{
    public interface IAlterarStatusLocacaoUseCase
    {
        public RespostaPadrao<string> ExecutarParaAndamento(Guid locacaoId);
        public RespostaPadrao<string> ExecutarParaFinalizada(Guid locacaoId);
    }
}
