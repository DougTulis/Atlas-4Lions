using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class DeletarPessoaUseCase
    {
        private readonly ICrud<PessoaDTO> pessoaRepositorio;
        public DeletarPessoaUseCase(ICrud<PessoaDTO> pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }
        public void Executar(PessoaDTO pessoaDTO)
        {
            pessoaRepositorio.Deletar(pessoaDTO);
        }
    }
}
