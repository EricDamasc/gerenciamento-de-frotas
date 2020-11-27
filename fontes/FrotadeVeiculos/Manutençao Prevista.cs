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
    public partial class Manutençao_Prevista : Form
    {
        private clsAdicionarManutencaBll clsmanutencaoBll = new clsAdicionarManutencaBll();
        private clsAdicionarManutencaoDto Manutencao = new clsAdicionarManutencaoDto();

        public Manutençao_Prevista()
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
            GRID_MANUTENCAO_Prevista.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_MANUTENCAO_Prevista.DataSource = clsmanutencaoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_MANUTENCAO_Prevista.DataSource = clsmanutencaoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_MANUTENCAO_Prevista.DataSource = clsmanutencaoBll.ObterDados(2, filtro);
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
            GRID_MANUTENCAO_Prevista.ReadOnly = true;
            GRID_MANUTENCAO_Prevista.ScrollBars = ScrollBars.Vertical;


            GRID_MANUTENCAO_Prevista.Columns[0].HeaderText = "ORDEM DE SERVIÇO";
            GRID_MANUTENCAO_Prevista.Columns[1].HeaderText = "PEÇA";
            GRID_MANUTENCAO_Prevista.Columns[2].HeaderText = "PLACA";
            GRID_MANUTENCAO_Prevista.Columns[3].HeaderText = "PROBLEMAS";
            GRID_MANUTENCAO_Prevista.Columns[4].HeaderText = "DATA";
            GRID_MANUTENCAO_Prevista.Columns[5].HeaderText = "TIPO DE MANUTENÇÃO";
    
            GRID_MANUTENCAO_Prevista.Columns[0].Width = 150;
            GRID_MANUTENCAO_Prevista.Columns[1].Width = 100;
            GRID_MANUTENCAO_Prevista.Columns[2].Width = 110;
            GRID_MANUTENCAO_Prevista.Columns[3].Width = 200;
            GRID_MANUTENCAO_Prevista.Columns[4].Width = 100;
            GRID_MANUTENCAO_Prevista.Columns[5].Width = 260;
        }

        private void btn_VOLTAR_Manutenção_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Manutençao_Prevista_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
