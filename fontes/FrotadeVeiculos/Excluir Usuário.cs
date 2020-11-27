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
    public partial class Excluir_Usuário : Form
    {
        private clsUsuarioBll usuarioBll = new clsUsuarioBll();
        private clsUsuarioDto ExcluirUsuario = new clsUsuarioDto();

        public Excluir_Usuário()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_EXCLUIR_Usuario_Click(object sender, EventArgs e)
        {

            if (txtCODIGO_Excluir_Usuario.Text == "")
            {
                MessageBox.Show("O CPF é obrigatória");
                LimparCampos();
            }
            else
            {
                usuarioBll.Excluir(txtCODIGO_Excluir_Usuario.Text);

                MessageBox.Show(
               "Usuário Excluido com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            GRID_Excluir_Usuario.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Excluir_Usuario.DataSource = usuarioBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Excluir_Usuario.DataSource = usuarioBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Excluir_Usuario.DataSource = usuarioBll.ObterDados(2, filtro);
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
            GRID_Excluir_Usuario.ReadOnly = true;
            GRID_Excluir_Usuario.ScrollBars = ScrollBars.Vertical;

            GRID_Excluir_Usuario.Columns[0].HeaderText = "PERFIL";
            GRID_Excluir_Usuario.Columns[3].HeaderText = "CPF";
            GRID_Excluir_Usuario.Columns[2].HeaderText = "EMAIL";
            GRID_Excluir_Usuario.Columns[1].HeaderText = "SENHA";

            GRID_Excluir_Usuario.Columns[0].Width = 150;
            GRID_Excluir_Usuario.Columns[3].Width = 150;
            GRID_Excluir_Usuario.Columns[2].Width = 250;
            GRID_Excluir_Usuario.Columns[1].Visible = false;
        }

        private void LimparCampos()
        {
            txtCODIGO_Excluir_Usuario.Text = "";
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Excluir_Usuario.CurrentRow.Index;

            txtCODIGO_Excluir_Usuario.Text = GRID_Excluir_Usuario["CPF", linhaSelecionada].Value.ToString();
        }

        private void btn_VOLTAR_UsuarioExcluir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GRID_Excluir_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void Excluir_Usuário_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
