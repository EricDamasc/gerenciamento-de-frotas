using bll;
using dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_FrotadeVeiculos
{
    public partial class Peças : Form
    {
        private clsPecaBll clspecaBll = new clsPecaBll();
        private clsPecasDto pecas = new clsPecasDto();

        public Peças()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void btn_ADD_Peças_Cadastro_Click(object sender, EventArgs e)
        {
         
            // VALIDAÇÃO DO CAMPO MARCA
            if (txtMARCA_Cadastro_de_Peças.Text == "")
            {
                MessageBox.Show("O Campo MARCA é obrigatório");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO PEÇAS
            else if (txtPEÇAS_Cadastro_de_Peças.Text == "")
            {
                MessageBox.Show("O campo PEÇAS é obrigatório");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO VALOR
            else if (txtVALOR_Cadastro_de_Peças.Text == "")
            {
                MessageBox.Show("O VALOR é obrigatório");
                Focus();
            }

            else
            {
                pecas.Peca = 0;
                pecas.Marca = txtMARCA_Cadastro_de_Peças.Text;
                pecas.Pecas = txtPEÇAS_Cadastro_de_Peças.Text;
                pecas.Valor = Convert.ToDecimal(txtVALOR_Cadastro_de_Peças.Text);
                pecas.OBS = txtOBS_Cadastro_de_Peças.Text;

                clspecaBll.Inserir(pecas);

                MessageBox.Show("PEÇA inserida com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarGrid();
        }

        private void btn_VOLTAR_Peças_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            CadastrarPecas_GRID.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    CadastrarPecas_GRID.DataSource = clspecaBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        CadastrarPecas_GRID.DataSource = clspecaBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            CadastrarPecas_GRID.DataSource = clspecaBll.ObterDados(2, filtro);
                        }
                    }
                    FormatarGrid();
                }
            }

            catch
            {
                throw;
            }
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = CadastrarPecas_GRID.CurrentRow.Index;

            txtCODIGO_Cadastro_de_Peças.Text = CadastrarPecas_GRID[0, linhaSelecionada].Value.ToString();
            txtVALOR_Cadastro_de_Peças.Text = CadastrarPecas_GRID[1, linhaSelecionada].Value.ToString();
            txtPEÇAS_Cadastro_de_Peças.Text = CadastrarPecas_GRID[2, linhaSelecionada].Value.ToString();
            txtMARCA_Cadastro_de_Peças.Text = CadastrarPecas_GRID[3, linhaSelecionada].Value.ToString();
            txtOBS_Cadastro_de_Peças.Text = CadastrarPecas_GRID[4, linhaSelecionada].Value.ToString();
        }

        private void FormatarGrid()
        {
            CadastrarPecas_GRID.ReadOnly = true;
            CadastrarPecas_GRID.ScrollBars = ScrollBars.Vertical;


            CadastrarPecas_GRID.Columns[0].HeaderText = "CODIGO";
            CadastrarPecas_GRID.Columns[1].HeaderText = "VALOR";
            CadastrarPecas_GRID.Columns[2].HeaderText = "PEÇA";
            CadastrarPecas_GRID.Columns[3].HeaderText = "MARCA";
            CadastrarPecas_GRID.Columns[4].HeaderText = "OBSERVAÇÃO";

            CadastrarPecas_GRID.Columns[0].Width = 60;
            CadastrarPecas_GRID.Columns[1].Width = 115;
            CadastrarPecas_GRID.Columns[2].Width = 150;
            CadastrarPecas_GRID.Columns[3].Width = 150;
            CadastrarPecas_GRID.Columns[4].Width = 300;
        }

        private void btn_VOLTAR_Usuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarPecas_GRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void Peças_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
