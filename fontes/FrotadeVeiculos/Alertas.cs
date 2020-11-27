using bll;
using dto;
using System;
using System.Windows.Forms;

namespace wf_FrotadeVeiculos
{
    public partial class Alertas : Form
    {
        private clsMultasBll _multasBll = new clsMultasBll();
        private clsMultasDto Multas = new clsMultasDto();

        private clsMotoristasBll clsMotoristas = new clsMotoristasBll();
        private clsMotoristasDto Motoristas = new clsMotoristasDto();


        public Alertas()
        {
            InitializeComponent();
            CarregarGrid();
        }


        protected void CarregarGrid()
        {
            CarregarGridMultas(0, "");
            CarregarGridMotorista(0, "");
        }

        private void CarregarGridMultas(int tipo, String filtro)
        {
            GRID_Alertas_Multas.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Alertas_Multas.DataSource = _multasBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Alertas_Multas.DataSource = _multasBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Alertas_Multas.DataSource = _multasBll.ObterDados(2, filtro);
                        }
                    }
                }
            }

            catch
            {
                throw;
            }
        }

        private void CarregarGridMotorista(int tipo, String filtro)
        {
            GRID_Alertas_Motorista.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_Alertas_Motorista.DataSource = clsMotoristas.obterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_Alertas_Motorista.DataSource = clsMotoristas.obterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_Alertas_Motorista.DataSource = clsMotoristas.ObterDados(2, filtro);
                        }
                    }
                }
            }

            catch
            {
                throw;
            }
        }

        private void FormatarGridMultas()
        {
            GRID_Alertas_Multas.ReadOnly = true;
            GRID_Alertas_Multas.ScrollBars = ScrollBars.Vertical;


            GRID_Alertas_Multas.Columns[0].HeaderText = "CÓDIGO";
            GRID_Alertas_Multas.Columns[2].HeaderText = "MOTORISTA";
            GRID_Alertas_Multas.Columns[1].HeaderText = "PLACA";
            GRID_Alertas_Multas.Columns[4].HeaderText = "VALOR";
            GRID_Alertas_Multas.Columns[3].HeaderText = "VENCIMENTO";

            GRID_Alertas_Multas.Columns[0].Width = 100;
            GRID_Alertas_Multas.Columns[1].Width = 110;
            GRID_Alertas_Multas.Columns[2].Width = 110;
            GRID_Alertas_Multas.Columns[3].Width = 185;
            GRID_Alertas_Multas.Columns[4].Width = 100;
        }

        private void FormatarGridMotorista()
        {
            GRID_Alertas_Motorista.ReadOnly = true;
            GRID_Alertas_Motorista.ScrollBars = ScrollBars.Vertical;


            GRID_Alertas_Motorista.Columns[0].HeaderText = "CÓDIGO";
            GRID_Alertas_Motorista.Columns[1].HeaderText = "RG";
            GRID_Alertas_Motorista.Columns[2].HeaderText = "CPF";
            GRID_Alertas_Motorista.Columns[3].HeaderText = "NOME";
            GRID_Alertas_Motorista.Columns[4].HeaderText = "NASCIMENTO";
            GRID_Alertas_Motorista.Columns[5].HeaderText = "NUM. CNH";
            GRID_Alertas_Motorista.Columns[6].HeaderText = "TIPO CNH";
            GRID_Alertas_Motorista.Columns[7].HeaderText = "VALIDADE CNH";

            GRID_Alertas_Motorista.Columns[0].Width = 60;
            GRID_Alertas_Motorista.Columns[1].Visible = false;
            GRID_Alertas_Motorista.Columns[2].Width = 90;
            GRID_Alertas_Motorista.Columns[3].Width = 180;
            GRID_Alertas_Motorista.Columns[4].Visible = false;
            GRID_Alertas_Motorista.Columns[5].Width = 115;
            GRID_Alertas_Motorista.Columns[6].Visible = false;
            GRID_Alertas_Motorista.Columns[7].Width = 140;
        }

        private void btn_VOLTAR_Alertas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGridMultas();
            FormatarGridMotorista();
        }

        private void btn_PagarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodigoMultas.Text == "")
                {
                    MessageBox.Show("O Codigo é obrigatório");
                    Focus();
                }
                else
                {
                    if (MessageBox.Show("Confirma a Exclusão?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _multasBll.Excluir(Convert.ToInt32(txt_CodigoMultas.Text.ToString()));

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
            FormatarGridMultas();
        }

        private void btn_DespedirMotorista_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodigoCNH.Text == "")
                {
                    MessageBox.Show("O Codigo é obrigatório");
                    Focus();
                }
                else
                {
                    if (MessageBox.Show("Confirma a Exclusão?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clsMotoristas.Excluir(Convert.ToInt32(txt_CodigoCNH.Text));

                        MessageBox.Show(
                       "Motorista Excluido com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }

            CarregarGrid();
            FormatarGridMotorista();
        }
   
        private void AtualizarGridMultas()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Alertas_Multas.CurrentRow.Index;

            txt_CodigoMultas.Text = GRID_Alertas_Multas[0, linhaSelecionada].Value.ToString();
        }

        private void AtualizarGridMotoristas()
        {
            int linhaSelecionada;

            linhaSelecionada = GRID_Alertas_Motorista.CurrentRow.Index;

            txt_CodigoCNH.Text = GRID_Alertas_Motorista[0, linhaSelecionada].Value.ToString();
        }

        private void GRID_Alertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGridMultas();
        }

        private void GRID_Alertas2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGridMotoristas();
        }
    }
}
