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
    public partial class Exibir_Usuário : Form
    {
        private clsUsuarioBll clsUsuarioBll = new clsUsuarioBll();
        private clsUsuarioDto usuario = new clsUsuarioDto();

        public Exibir_Usuário()
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
            GRID_Exibir_Usuario.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Exibir_Usuario.DataSource = clsUsuarioBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Exibir_Usuario.DataSource = clsUsuarioBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Exibir_Usuario.DataSource = clsUsuarioBll.ObterDados(2, filtro);
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
            GRID_Exibir_Usuario.ReadOnly = true;
            GRID_Exibir_Usuario.ScrollBars = ScrollBars.Vertical;

            GRID_Exibir_Usuario.Columns[0].HeaderText = "PERFIL";
            GRID_Exibir_Usuario.Columns[3].HeaderText = "CPF";
            GRID_Exibir_Usuario.Columns[2].HeaderText = "EMAIL";
            GRID_Exibir_Usuario.Columns[1].HeaderText = "SENHA";

            GRID_Exibir_Usuario.Columns[0].Width = 200;
            GRID_Exibir_Usuario.Columns[3].Width = 150;
            GRID_Exibir_Usuario.Columns[2].Width = 300;
            GRID_Exibir_Usuario.Columns[1].Visible = false;

        }

        private void btn_VOLTAR_Usuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Exibir_Usuário_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
