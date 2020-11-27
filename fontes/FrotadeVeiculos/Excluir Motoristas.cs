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
    public partial class Excluir_Motoristas : Form
    {
        private clsMotoristasBll clsMotoristasBll = new clsMotoristasBll();
        private clsMotoristasDto motorista = new clsMotoristasDto();

        public Excluir_Motoristas()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_EXCLUIR_Motoristas_Click(object sender, EventArgs e)
        {
            if (txtCODIGO_Excluir_Motorista.Text == "")
            {
                MessageBox.Show("O Campo CODIGO é obrigatória");
                LimparCampos();
            }
            else
            {
                clsMotoristasBll.Excluir(Convert.ToInt32(txtCODIGO_Excluir_Motorista.Text));

                MessageBox.Show(
               "Motorista Excluido com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            GRID_Excluir_Motorista.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    GRID_Excluir_Motorista.DataSource = clsMotoristasBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Excluir_Motorista.DataSource = clsMotoristasBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Excluir_Motorista.DataSource = clsMotoristasBll.ObterDados(2, filtro);
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

        private void FormatarGrid()
        {
            GRID_Excluir_Motorista.ReadOnly = true;
            GRID_Excluir_Motorista.ScrollBars = ScrollBars.Vertical;


            GRID_Excluir_Motorista.Columns[0].HeaderText = "ID";
            GRID_Excluir_Motorista.Columns[1].HeaderText = "RG";
            GRID_Excluir_Motorista.Columns[2].HeaderText = "CPF";
            GRID_Excluir_Motorista.Columns[3].HeaderText = "NOME";
            GRID_Excluir_Motorista.Columns[4].HeaderText = "NASCIMENTO";
            GRID_Excluir_Motorista.Columns[5].HeaderText = "NUM. CNH";
            GRID_Excluir_Motorista.Columns[6].HeaderText = "TIPO CNH";
            GRID_Excluir_Motorista.Columns[7].HeaderText = "VALIDADE CNH";

            GRID_Excluir_Motorista.Columns[0].Width = 60;
            GRID_Excluir_Motorista.Columns[1].Width = 90;
            GRID_Excluir_Motorista.Columns[2].Width = 90;
            GRID_Excluir_Motorista.Columns[3].Width = 200;
            GRID_Excluir_Motorista.Columns[4].Width = 115;
            GRID_Excluir_Motorista.Columns[5].Width = 130;
            GRID_Excluir_Motorista.Columns[6].Width = 90;
            GRID_Excluir_Motorista.Columns[7].Width = 140;
        }

        private void LimparCampos()
        {
            txtCODIGO_Excluir_Motorista.Text = "";
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Excluir_Motorista.CurrentRow.Index;

            txtCODIGO_Excluir_Motorista.Text = GRID_Excluir_Motorista[0, linhaSelecionada].Value.ToString();
        }

        private void GRID_Excluir_Motorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void btn_VOLTAR_Motoristas_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Excluir_Motoristas_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
