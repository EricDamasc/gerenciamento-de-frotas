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
    public partial class Excluir_Veiculo : Form
    {
        private clsVeiculoBll addVeiculoBll = new clsVeiculoBll();
        private clsVeiculoDto ExcluirVeiculo = new clsVeiculoDto();

        public Excluir_Veiculo()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_Excluir_Veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPLACA_EXCLUIR_Frotas.Text == "")
                {
                    MessageBox.Show("A placa é obrigatória");
                    Focus();
                }
                else
                {
                    addVeiculoBll.Excluir(txtPLACA_EXCLUIR_Frotas.Text);

                    MessageBox.Show(
                   "Veiculo Excluido com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                CarregarGrid();
                FormatarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
        }

            protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            ExcluirGridVEICULO.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    ExcluirGridVEICULO.DataSource = addVeiculoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        ExcluirGridVEICULO.DataSource = addVeiculoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            ExcluirGridVEICULO.DataSource = addVeiculoBll.ObterDados(2, filtro);
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
            ExcluirGridVEICULO.ReadOnly = true;
            ExcluirGridVEICULO.ScrollBars = ScrollBars.Vertical;

            ExcluirGridVEICULO.Columns[0].HeaderText = "PLACA";
            ExcluirGridVEICULO.Columns[3].HeaderText = "MARCA";
            ExcluirGridVEICULO.Columns[2].HeaderText = "MODELO";
            ExcluirGridVEICULO.Columns[1].HeaderText = "ANO";
            ExcluirGridVEICULO.Columns[4].HeaderText = "CONSUMO";
            ExcluirGridVEICULO.Columns[5].HeaderText = "TIPO";
            ExcluirGridVEICULO.Columns[6].HeaderText = "DISPONIBILIDADE";

            ExcluirGridVEICULO.Columns[0].Width = 120;
            ExcluirGridVEICULO.Columns[1].Width = 100;
            ExcluirGridVEICULO.Columns[2].Width = 150;
            ExcluirGridVEICULO.Columns[3].Width = 150;
            ExcluirGridVEICULO.Columns[4].Width = 150;
            ExcluirGridVEICULO.Columns[5].Width = 150;
            ExcluirGridVEICULO.Columns[6].Width = 170;
        }

        private void LimparCampos()
        {
            txtPLACA_EXCLUIR_Frotas.Text = "";
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = ExcluirGridVEICULO.CurrentRow.Index;

            txtPLACA_EXCLUIR_Frotas.Text = ExcluirGridVEICULO[0, linhaSelecionada].Value.ToString();
        }

        private void btn_VOLTAR_EXIBIR_VEICULO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcluirGridVEICULO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void Excluir_Veiculo_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
