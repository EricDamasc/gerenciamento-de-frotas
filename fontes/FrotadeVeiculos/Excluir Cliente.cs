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
    public partial class Excluir_Cliente : Form
    {
        private clsClienteBll clienteBll = new clsClienteBll();
        private clsClienteDto ExcluirCliente = new clsClienteDto();

        public Excluir_Cliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_EXCLUIR_Cliente_Click(object sender, EventArgs e)
        {
            if (txtCNPJ_Excluir_Cliente.Text == "")
            {
                MessageBox.Show("O CNPJ é obrigatória");
                LimparCampos();
            }
            else
            {
                clienteBll.Excluir(txtCNPJ_Excluir_Cliente.Text);

                MessageBox.Show(
               "Cliente Excluido com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CarregarGrid();
            FormatarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            GRID_Excluir_Cliente.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Excluir_Cliente.DataSource = clienteBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Excluir_Cliente.DataSource = clienteBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Excluir_Cliente.DataSource = clienteBll.ObterDados(2, filtro);
                        }
                    }
                }
            }

            catch
            {
                throw;
            }
        }
        
        private void FormatarGrid()
        {
            GRID_Excluir_Cliente.ReadOnly = true;
            GRID_Excluir_Cliente.ScrollBars = ScrollBars.Vertical;

            GRID_Excluir_Cliente.Columns[0].HeaderText = "CÓDIGO";
            GRID_Excluir_Cliente.Columns[1].HeaderText = "TELEFONE";
            GRID_Excluir_Cliente.Columns[3].HeaderText = "CNPJ";
            GRID_Excluir_Cliente.Columns[2].HeaderText = "EMPRESA";
            GRID_Excluir_Cliente.Columns[4].HeaderText = "E-MAIL";
            GRID_Excluir_Cliente.Columns[5].HeaderText = "CEP";
            GRID_Excluir_Cliente.Columns[6].HeaderText = "ESTADOS";

            GRID_Excluir_Cliente.Columns[0].Width = 60;
            GRID_Excluir_Cliente.Columns[1].Width = 100;
            GRID_Excluir_Cliente.Columns[2].Width = 260;
            GRID_Excluir_Cliente.Columns[3].Width = 150;
            GRID_Excluir_Cliente.Columns[4].Width = 300;
            GRID_Excluir_Cliente.Columns[5].Width = 65;
            GRID_Excluir_Cliente.Columns[6].Width = 160;
        }

        private void LimparCampos()
        {
            txtCNPJ_Excluir_Cliente.Text = "";
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Excluir_Cliente.CurrentRow.Index;

            txtCNPJ_Excluir_Cliente.Text = GRID_Excluir_Cliente["CNPJ", linhaSelecionada].Value.ToString();
        }

        private void GRID_Excluir_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void btn_VOLTAR_Cliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Excluir_Cliente_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
