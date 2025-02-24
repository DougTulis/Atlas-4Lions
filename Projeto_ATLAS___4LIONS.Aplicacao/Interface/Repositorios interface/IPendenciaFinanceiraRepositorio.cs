﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IPendenciaFinanceiraRepositorio
    {
        public IEnumerable<PendenciaFinanceiraDTO> ListarTodos();
        public IEnumerable<PendenciaFinanceiraDTO> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(PendenciaFinanceira objeto);
        public void Deletar(PendenciaFinanceiraDTO objeto);
        public PendenciaFinanceiraDTO? RecuperarPorId(Guid id);
    }
}
