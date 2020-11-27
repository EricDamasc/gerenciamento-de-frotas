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
    public partial class Exibir_Cliente : Form
    {
        private clsClienteBll clienteBll = new clsClienteBll();
        private clsClienteDto Cliente = new clsClienteDto();

        public Exibir_Cliente()
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
            GRID_Exibir_Cliente.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Exibir_Cliente.DataSource = clienteBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Exibir_Cliente.DataSource = clienteBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Exibir_Cliente.DataSource = clienteBll.ObterDados(2, filtro);
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
            GRID_Exibir_Cliente.ReadOnly = true;
            GRID_Exibir_Cliente.ScrollBars = ScrollBars.Vertical;

            GRID_Exibir_Cliente.Columns[0].HeaderText = "CÓDIGO";
            GRID_Exibir_Cliente.Columns[1].HeaderText = "TELEFONE";
            GRID_Exibir_Cliente.Columns[3].HeaderText = "CNPJ";
            GRID_Exibir_Cliente.Columns[2].HeaderText = "EMPRESA";
            GRID_Exibir_Cliente.Columns[4].HeaderText = "E-MAIL";
            GRID_Exibir_Cliente.Columns[5].HeaderText = "CEP";
            GRID_Exibir_Cliente.Columns[6].HeaderText = "ESTADOS";

            GRID_Exibir_Cliente.Columns[0].Width = 60;
            GRID_Exibir_Cliente.Columns[1].Width = 90;
            GRID_Exibir_Cliente.Columns[2].Width = 238;
            GRID_Exibir_Cliente.Columns[3].Width = 110;
            GRID_Exibir_Cliente.Columns[4].Width = 240;
            GRID_Exibir_Cliente.Columns[5].Width = 65;
            GRID_Exibir_Cliente.Columns[6].Width = 120;
        }

        private void btn_VOLTAR_Pneus_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exibir_Cliente_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}