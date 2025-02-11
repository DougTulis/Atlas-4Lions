using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
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
    public partial class FrmCadAutomovel : Form
    {
        private readonly ITabelaPrecoRepositorio tabelaPrecoRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly CadastrarVeiculoUseCase cadastrarVeiculoUseCase;
        private readonly CadastrarPrecoAutomovelUseCase cadastrarPrecoAutomovelUseCase; 
        private readonly ListarAutomovelUseCase listarAutomovelUseCase;
    
        public FrmCadAutomovel()
        {
            automovelRepositorio = new AutomovelRepositorio();
            tabelaPrecoRepositorio = new TabelaPrecoRepositorio();
            cadastrarVeiculoUseCase = new CadastrarVeiculoUseCase(automovelRepositorio);
            listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);
            cadastrarPrecoAutomovelUseCase = new CadastrarPrecoAutomovelUseCase(tabelaPrecoRepositorio);
            InitializeComponent();
        }

        private void FrmCadAutomovel_Load(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void lblCor_Click(object sender, EventArgs e)
        {

        }

        private void lblChassi_Click(object sender, EventArgs e)
        {

        }

        private void lblOleoKm_Click(object sender, EventArgs e)
        {

        }

        private void lblFreioKm_Click(object sender, EventArgs e)
        {

        }

        private void lblDescricaoPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChassi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRenavam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOleoKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFreioKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricaoPreco_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAutomovel_Click(object sender, EventArgs e)
        {

            var automovelDto = new AutomovelDTO
            { 
                Modelo = txtModelo.Text,
                Ano = txtAno.Text,
                Cor = txtCor.Text,
                Placa = txtPlaca.Text,
                Chassi = txtChassi.Text,
                Renavam = txtRenavam.Text,
                Oleokm = int.TryParse(txtOleoKm.Text, out int oleo) ? oleo : null,
                PastilhaFreioKm = int.TryParse(txtFreioKm.Text, out int freio) ? freio : null
            };
            cadastrarVeiculoUseCase.Executar(automovelDto);

            var precoDto = new TabelaPrecoDTO
            {
                Descricao = txtDescricaoPreco.Text,
                Valor = decimal.Parse(txtPreco.Text)
            };
            cadastrarVeiculoUseCase.Executar(automovelDto);
            cadastrarPrecoAutomovelUseCase.Executar(precoDto);

            
        }


    }
}
