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
    public partial class Exibir_Motoristas : Form
    {
        private clsMotoristasBll clsMotoristasBll = new clsMotoristasBll();
        private clsMotoristasDto Motorista = new clsMotoristasDto();

        public Exibir_Motoristas()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            GRID_Exibir_Motoristas.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    GRID_Exibir_Motoristas.DataSource = clsMotoristasBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Exibir_Motoristas.DataSource = clsMotoristasBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Exibir_Motoristas.DataSource = clsMotoristasBll.ObterDados(2, filtro);
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
            GRID_Exibir_Motoristas.ReadOnly = true;
            GRID_Exibir_Motoristas.ScrollBars = ScrollBars.Vertical;

            
            GRID_Exibir_Motoristas.Columns[0].HeaderText = "CÓDIGO";
            GRID_Exibir_Motoristas.Columns[1].HeaderText = "RG";
            GRID_Exibir_Motoristas.Columns[2].HeaderText = "CPF";
            GRID_Exibir_Motoristas.Columns[3].HeaderText = "NOME";
            GRID_Exibir_Motoristas.Columns[4].HeaderText = "NASCIMENTO";
            GRID_Exibir_Motoristas.Columns[5].HeaderText = "NUM. CNH";
            GRID_Exibir_Motoristas.Columns[6].HeaderText = "TIPO CNH";
            GRID_Exibir_Motoristas.Columns[7].HeaderText = "VALIDADE CNH";

            GRID_Exibir_Motoristas.Columns[0].Width = 60;
            GRID_Exibir_Motoristas.Columns[1].Width = 90;
            GRID_Exibir_Motoristas.Columns[2].Width = 90;
            GRID_Exibir_Motoristas.Columns[3].Width = 200;
            GRID_Exibir_Motoristas.Columns[4].Width = 115;
            GRID_Exibir_Motoristas.Columns[5].Width = 130;
            GRID_Exibir_Motoristas.Columns[6].Width = 90;
            GRID_Exibir_Motoristas.Columns[7].Width = 140;
        }

        private void btn_VOLTAR_Pneus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GRID_Exibir_Motoristas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exibir_Motoristas_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
