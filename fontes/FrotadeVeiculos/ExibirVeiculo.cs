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
    public partial class ExibirVeiculo : Form
    {
        private clsVeiculoBll clsAddVeiculoBll = new clsVeiculoBll();
        private clsVeiculoDto veiculo = new clsVeiculoDto();

        public ExibirVeiculo()
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
            GRID_Exibir_Veiculos.AutoGenerateColumns = true;
            try
            {
                if (tipo == 0)
                {
                    GRID_Exibir_Veiculos.DataSource = clsAddVeiculoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Exibir_Veiculos.DataSource = clsAddVeiculoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Exibir_Veiculos.DataSource = clsAddVeiculoBll.ObterDados(2, filtro);
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
            GRID_Exibir_Veiculos.ReadOnly = true;
            GRID_Exibir_Veiculos.ScrollBars = ScrollBars.Vertical;

            GRID_Exibir_Veiculos.Columns[0].HeaderText = "PLACA";
            GRID_Exibir_Veiculos.Columns[3].HeaderText = "MARCA";
            GRID_Exibir_Veiculos.Columns[2].HeaderText = "MODELO";
            GRID_Exibir_Veiculos.Columns[1].HeaderText = "ANO";
            GRID_Exibir_Veiculos.Columns[4].HeaderText = "CONSUMO";
            GRID_Exibir_Veiculos.Columns[5].HeaderText = "TIPO";
            GRID_Exibir_Veiculos.Columns[6].HeaderText = "DISPONIBILIDADE";
            
            GRID_Exibir_Veiculos.Columns[0].Width = 100;
            GRID_Exibir_Veiculos.Columns[1].Width = 80;
            GRID_Exibir_Veiculos.Columns[2].Width = 150;
            GRID_Exibir_Veiculos.Columns[3].Width = 150;
            GRID_Exibir_Veiculos.Columns[4].Width = 120;
            GRID_Exibir_Veiculos.Columns[5].Width = 150;
            GRID_Exibir_Veiculos.Columns[6].Width = 170;
        }

        private void btn_VOLTAR_Veiculos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExibirVeiculo_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
