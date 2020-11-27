using bll;
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
    public partial class Pagamentos : Form
    {
        private clsPecaBll pecaBll = new clsPecaBll();
        private clsPneusBll PneusBll = new clsPneusBll();

        public Pagamentos()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGridPneus(0, "");
            CarregarGridPecas(0, "");
        }

        private void CarregarGridPneus(int tipo, string filtro)
        {
            GRID_PNEUS.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_PNEUS.DataSource = PneusBll.ObterDados(0, String.Empty);
                }
                else if (tipo == 1)
                {
                    GRID_PNEUS.DataSource = PneusBll.ObterDados(1, filtro);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarGridPecas(int tipo, string filtro)
        {
            GRID_PEÇAS.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_PEÇAS.DataSource = pecaBll.ObterDados(0, String.Empty);
                }
                else if (tipo == 1)
                {
                    GRID_PEÇAS.DataSource = pecaBll.ObterDados(1, filtro);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatarGridPeca()
        {
            GRID_PEÇAS.ReadOnly = true;
            GRID_PEÇAS.ScrollBars = ScrollBars.Vertical;


            GRID_PEÇAS.Columns[0].HeaderText = "CÓDIGO";
            GRID_PEÇAS.Columns[3].HeaderText = "MARCA";
            GRID_PEÇAS.Columns[2].HeaderText = "PEÇA";
            GRID_PEÇAS.Columns[1].HeaderText = "VALOR";
            GRID_PEÇAS.Columns[4].HeaderText = "OBSERVAÇÃO";

            GRID_PEÇAS.Columns[0].Width = 60;
            GRID_PEÇAS.Columns[1].Width = 100;
            GRID_PEÇAS.Columns[2].Width = 120;
            GRID_PEÇAS.Columns[3].Width = 120;
            GRID_PEÇAS.Columns[4].Width = 130;
        }

        private void FormatarGridPneu()
        {
            GRID_PNEUS.ReadOnly = true;
            GRID_PNEUS.ScrollBars = ScrollBars.Vertical;


            GRID_PNEUS.Columns[0].HeaderText = "CÓDIGO";
            GRID_PNEUS.Columns[1].HeaderText = "MARCA";
            GRID_PNEUS.Columns[2].HeaderText = "TAMANHO";
            GRID_PNEUS.Columns[3].HeaderText = "PREÇO";
            GRID_PNEUS.Columns[4].HeaderText = "OBSERVAÇÃO";

            GRID_PNEUS.Columns[0].Width = 100;
            GRID_PNEUS.Columns[1].Width = 120;
            GRID_PNEUS.Columns[2].Width = 100;
            GRID_PNEUS.Columns[3].Width = 100;
            GRID_PNEUS.Columns[4].Width = 150;
        }

        private void AtualizarGridPneu()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_PNEUS.CurrentRow.Index;

            txt_pneu.Text = GRID_PNEUS[0, linhaSelecionada].Value.ToString();
        }

        private void AtualizarGridPecas()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_PEÇAS.CurrentRow.Index;

            txt_peca.Text = GRID_PEÇAS[0, linhaSelecionada].Value.ToString();
        }

        private void btn_VOLTAR_Pagamentos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGridPeca();
            FormatarGridPneu();
        }

        private void GRID_PNEUS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGridPneu();
        }

        private void GRID_PEÇAS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGridPecas();
        }

        private void btn_PagarPneu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pneu.Text == "")
                {
                    MessageBox.Show("O Codigo é obrigatório");
                    Focus();
                }
                else
                {
                    if (MessageBox.Show("Confirma a Exclusão?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        PneusBll.Excluir(Convert.ToInt32(txt_pneu.Text));

                        MessageBox.Show(
                       "Multa Paga com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }

            CarregarGrid();
        }

        private void btn_PagarPecas_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_peca.Text == "")
                {
                    MessageBox.Show("O Codigo é obrigatório");
                    Focus();
                }
                else
                {
                    if (MessageBox.Show("Confirma a Exclusão?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        pecaBll.Excluir(Convert.ToInt32(txt_peca.Text));

                        MessageBox.Show(
                       "Multa Paga com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }

            CarregarGrid();
        }
    }
}
