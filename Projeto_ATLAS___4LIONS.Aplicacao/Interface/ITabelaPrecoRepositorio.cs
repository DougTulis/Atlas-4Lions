﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface  ITabelaPrecoRepositorio
    {
        public IEnumerable<TabelaPrecoDTO> ListarTodos();

        public IEnumerable<TabelaPrecoDTO> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(TabelaPrecoDTO objeto);
        public void Deletar(TabelaPrecoDTO objeto);
        public TabelaPrecoDTO? RecuperarPorId(int id);
    }
}
