﻿using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPendenciaFinanceiraUseCase : IListarPendenciaFinanceiraUseCase
    {

        private readonly IPendenciaFinanceiraRepositorio _pendenciaRepositorio;
        public ListarPendenciaFinanceiraUseCase(IPendenciaFinanceiraRepositorio pendenciaRepositorio)
        {
            _pendenciaRepositorio = pendenciaRepositorio;
        }
        public IEnumerable<PendenciaFinanceiraDTO> Executar()
        {
            return _pendenciaRepositorio.ListarTodos();
      
        }
        public PendenciaFinanceiraDTO? ExecutarRecuperarPorId(int id)
        {
            return _pendenciaRepositorio.RecuperarPorId(id);
        }
    }
}