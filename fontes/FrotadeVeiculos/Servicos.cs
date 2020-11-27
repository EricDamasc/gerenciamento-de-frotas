using System;
using System.Windows.Forms;
using bll;

namespace wf_FrotadeVeiculos
{
    public partial class Servicos : Form
    {
        clsServicoBll servicosBll = new clsServicoBll();

        public Servicos()
        {
            InitializeComponent();
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, string filtro)
        {
            GRID_Exibir_Servicos.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Exibir_Servicos.DataSource = servicosBll.Obterdados(0, String.Empty);
                }
                else if (tipo == 1)
                {
                    GRID_Exibir_Servicos.DataSource = servicosBll.Obterdados(1, filtro);
                }
                else if (tipo == 2)
                {
                    GRID_Exibir_Servicos.DataSource = servicosBll.Obterdados(1, filtro);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormatarGridMultas();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbServicos.Text == "MULTAS")
                {
                    CarregarGrid(0, String.Empty);
                    FormatarGridMultas();
                }

                else if (cbServicos.Text == "MANUTENÇÃO")
                {
                    CarregarGrid(1, String.Empty);
                    FormatarGridManutenção();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
        }

        private void FormatarGridMultas()
        {
            GRID_Exibir_Servicos.ReadOnly = true;
            GRID_Exibir_Servicos.ScrollBars = ScrollBars.Vertical;


            GRID_Exibir_Servicos.Columns[0].HeaderText = "CÓDIGO";
            GRID_Exibir_Servicos.Columns[2].HeaderText = "PLACA";
            GRID_Exibir_Servicos.Columns[1].HeaderText = "MOTORISTA";
            GRID_Exibir_Servicos.Columns[4].HeaderText = "VENCIMENTO";
            GRID_Exibir_Servicos.Columns[3].HeaderText = "VALOR";

            GRID_Exibir_Servicos.Columns[0].Width = 150;
            GRID_Exibir_Servicos.Columns[2].Width = 150;
            GRID_Exibir_Servicos.Columns[1].Width = 150;
            GRID_Exibir_Servicos.Columns[4].Width = 185;
            GRID_Exibir_Servicos.Columns[3].Width = 200;
        }

        private void FormatarGridManutenção()
        {
            GRID_Exibir_Servicos.ReadOnly = true;
            GRID_Exibir_Servicos.ScrollBars = ScrollBars.Vertical;


            GRID_Exibir_Servicos.Columns[0].HeaderText = "CÓDIGO";
            GRID_Exibir_Servicos.Columns[1].HeaderText = "PEÇA";
            GRID_Exibir_Servicos.Columns[2].HeaderText = "PLACA";
            GRID_Exibir_Servicos.Columns[3].HeaderText = "PROBLEMAS";
            GRID_Exibir_Servicos.Columns[4].HeaderText = "DATA MANUTENÇÃO";
            GRID_Exibir_Servicos.Columns[5].HeaderText = "TIPO MANUTENÇÃO";

            GRID_Exibir_Servicos.Columns[0].Width = 120;
            GRID_Exibir_Servicos.Columns[1].Width = 120;
            GRID_Exibir_Servicos.Columns[2].Width = 110;
            GRID_Exibir_Servicos.Columns[3].Width = 220;
            GRID_Exibir_Servicos.Columns[4].Width = 150;
            GRID_Exibir_Servicos.Columns[5].Width = 220;
        }


        private void btn_VOLTAR_Servicos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Servicos_Load(object sender, EventArgs e)
        {

        }
    }
}

