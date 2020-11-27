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
    public partial class Cobrancas : Form
    {
        private clsCobrançasBll clsLocacao = new clsCobrançasBll();
        private clsAbastecimentoBll abastecimentoBll = new clsAbastecimentoBll();

        public Cobrancas()
        {
            InitializeComponent();
            CarregarGridLocacao(0, "");
        }


        protected void CarregarGrid()
        {
            CarregarGridLocacao(0, "");
            CarregarGridAbastecimento(0, "");
        }

        private void CarregarGridLocacao(int tipo, String filtro)
        {
            GRID_Exibir_Cobrancas.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Exibir_Cobrancas.DataSource = clsLocacao.Obterdados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Exibir_Cobrancas.DataSource = clsLocacao.Obterdados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Exibir_Cobrancas.DataSource = clsLocacao.Obterdados(2, filtro);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarGridAbastecimento(int tipo, String filtro)
        {
            GRID_Pagar_Abastecimentos.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Pagar_Abastecimentos.DataSource = abastecimentoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Pagar_Abastecimentos.DataSource = abastecimentoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Pagar_Abastecimentos.DataSource = abastecimentoBll.ObterDados(2, filtro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatarGridLocacao()
        {
            GRID_Exibir_Cobrancas.ReadOnly = true;
            GRID_Exibir_Cobrancas.ScrollBars = ScrollBars.Vertical;


            GRID_Exibir_Cobrancas.Columns[0].HeaderText = "CÓDIGO";
            GRID_Exibir_Cobrancas.Columns[1].HeaderText = "PLACA";
            GRID_Exibir_Cobrancas.Columns[2].HeaderText = "VALOR";
            GRID_Exibir_Cobrancas.Columns[3].HeaderText = "DATA DE LOCAÇÃO";

            GRID_Exibir_Cobrancas.Columns[0].Width = 100;
            GRID_Exibir_Cobrancas.Columns[1].Width = 120;
            GRID_Exibir_Cobrancas.Columns[2].Width = 160;
            GRID_Exibir_Cobrancas.Columns[3].Width = 200;
        }

        private void FormatarGridAbastecimento()
        {
            GRID_Pagar_Abastecimentos.ReadOnly = true;
            GRID_Pagar_Abastecimentos.ScrollBars = ScrollBars.Vertical;

            GRID_Pagar_Abastecimentos.Columns[0].HeaderText = "CÓDIGO";
            GRID_Pagar_Abastecimentos.Columns[1].HeaderText = "COMBUSTIVEL";
            GRID_Pagar_Abastecimentos.Columns[2].HeaderText = "PLACA";
            GRID_Pagar_Abastecimentos.Columns[3].HeaderText = "DATA ABASTECIMENTO";
            GRID_Pagar_Abastecimentos.Columns[4].HeaderText = "VALOR";

            GRID_Pagar_Abastecimentos.Columns[0].Width = 90;
            GRID_Pagar_Abastecimentos.Columns[1].Width = 110;
            GRID_Pagar_Abastecimentos.Columns[2].Width = 110;
            GRID_Pagar_Abastecimentos.Columns[3].Width = 165;
            GRID_Pagar_Abastecimentos.Columns[4].Width = 120;
        }

        private void btn_LiberarLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodigoLocacao.Text == "")
                {
                    MessageBox.Show("O Codigo é obrigatório");
                    Focus();
                }

                else if (MessageBox.Show("Confirma a Exclusão?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    clsLocacao.Excluir(Convert.ToInt32(txt_CodigoLocacao.Text));
                    MessageBox.Show(
                   "Liberado com sucesso!", "LIBERADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
            CarregarGrid();
            FormatarGridLocacao();
        }

        private void btn_Abastecimentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Abastecimento.Text == "")
                {
                    MessageBox.Show("O Codigo é obrigatório");
                    Focus();
                }
                else
                {
                    if (MessageBox.Show("Confirma a Exclusão?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        abastecimentoBll.Excluir(Convert.ToInt32(txt_Abastecimento.Text));

                        MessageBox.Show(
                       "Abastecimento pago com sucesso!", "Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
            CarregarGrid();
            FormatarGridAbastecimento();
        }

        private void AtualizarGridLocacao()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Exibir_Cobrancas.CurrentRow.Index;

            txt_CodigoLocacao.Text = GRID_Exibir_Cobrancas[0, linhaSelecionada].Value.ToString();
        }

        private void AtualizarGridAbastecimentos()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Pagar_Abastecimentos.CurrentRow.Index;

            txt_Abastecimento.Text = GRID_Pagar_Abastecimentos[0, linhaSelecionada].Value.ToString();
        }

        private void Cobrancas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGridAbastecimento();
            FormatarGridLocacao();
        }

        private void GRID_Exibir_Cobrancas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGridLocacao();
        }

        private void GRID_Pagar_Abastecimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGridAbastecimentos();
        }

        private void Cobrancas_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Console.Beep();
            MessageBox.Show("AQUI ESTÃO TODAS AS COBRANÇAS!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_VOLTAR_Cobrancas_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
