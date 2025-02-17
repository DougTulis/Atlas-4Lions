using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadPessoas : Form
    {
        private readonly CadastrarPessoaUseCase cadastrarPessoaUseCase;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly List<Notificacao> _notificacoes = new();


        public FrmCadPessoas()
        {
            pessoaRepositorio = new PessoaRepositorio();
            cadastrarPessoaUseCase = new CadastrarPessoaUseCase(pessoaRepositorio);

            InitializeComponent();

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
       {

        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadPessoas_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblContato_Click(object sender, EventArgs e)
        {

        }

        private void lblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblCnpj_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            try
            {

                var pessoaDto = new PessoaDTO
                {
                    Nome = textNome.Text,
                    Email = txtEmail.Text,
                    Contato = txtContato.Text,
                    Cpf = txtCpf.Text,
                    Cnpj = txtCnpj.Text,
                    DataNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                };
                cadastrarPessoaUseCase.Executar(pessoaDto);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
