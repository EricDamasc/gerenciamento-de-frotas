using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using bll;
using dto;

namespace wf_FrotadeVeiculos
{
    public partial class Veiculo : Form
    {
        private clsAddVeiculoBll clsAddVeiculo = new clsAddVeiculoBll();
        private clsAddVeiculoDto veiculo = new clsAddVeiculoDto();

        public Veiculo()
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
            ExibirGridVEICULO.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    ExibirGridVEICULO.DataSource = clsAddVeiculo.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        ExibirGridVEICULO.DataSource = clsAddVeiculo.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            ExibirGridVEICULO.DataSource = clsAddVeiculo.ObterDados(2, filtro);
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
            ExibirGridVEICULO.ReadOnly = true;
            ExibirGridVEICULO.ScrollBars = ScrollBars.Vertical;


            ExibirGridVEICULO.Columns[0].HeaderText = "Placa";
            ExibirGridVEICULO.Columns[1].HeaderText = "Ano do Veiculo";
            ExibirGridVEICULO.Columns[2].HeaderText = "Marca";
            ExibirGridVEICULO.Columns[3].HeaderText = "Modelo";
            ExibirGridVEICULO.Columns[4].HeaderText = "Consumo";
            ExibirGridVEICULO.Columns[5].HeaderText = "Tipo";
            ExibirGridVEICULO.Columns[6].HeaderText = "Disponibilidade";

            ExibirGridVEICULO.Columns[0].Width = 100;
            ExibirGridVEICULO.Columns[1].Width = 150;
            ExibirGridVEICULO.Columns[2].Width = 100;
            ExibirGridVEICULO.Columns[3].Width = 150;
            ExibirGridVEICULO.Columns[4].Width = 200;
            ExibirGridVEICULO.Columns[5].Width = 100;
            ExibirGridVEICULO.Columns[6].Width = 100;
        }

        private void btn_VOLTAR_Usuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
