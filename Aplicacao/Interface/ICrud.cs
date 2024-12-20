using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ICrud<T>
    {
        public IEnumerable<T> Listar();
        public void Adicionar(T objeto);
        public void Atualizar(T objeto);
        public void Deletar(T objeto);

    }
}
