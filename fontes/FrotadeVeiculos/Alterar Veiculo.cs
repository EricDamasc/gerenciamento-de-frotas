using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using bll;
using dto;

namespace wf_FrotadeVeiculos
{
    public partial class Alterar_Veiculo : Form
    {
        private clsVeiculoBll clsAddVeiculoBll = new clsVeiculoBll();
        private clsVeiculoDto AlterarVeiculo = new clsVeiculoDto();

        public Alterar_Veiculo()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_Alterar_Veiculo_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO PLACA
            if (txtPLACA_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O campo PLACA é obrigatório");
                LimparCampos();
            }
            // VALIDAÇÃO DO CAMPO ANO
            else if (txtMODELO_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O ANO é obrigatório");
                LimparCampos();
            }
            // VALIDAÇÃO DO CAMPO MARCA
            if (txtMARCA_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O campo MARCA é obrigatório");
                LimparCampos();
            }
            // VALIDAÇÃO DO CAMPO MODELO
            else if (txtTIPO_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O MODELO é obrigatório");
                LimparCampos();
            }
            // VALIDAÇÃO DO CAMPO CONSUMO
            if (txtANO_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O campo CONSUMO é obrigatório");
                LimparCampos();
            }
            // VALIDAÇÃO DO CAMPO TIPO
            else if (txtDISPONIBILIDADE_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O TIPO é obrigatório");
                LimparCampos();
            }
            // VALIDAÇÃO DO CAMPO DISPONIBILIDADE
            if (txtCONSUMO_Alterar_Frotas.Text == "")
            {
                MessageBox.Show("O campo DISPONIBILIDADE é obrigatório");
                LimparCampos();
            }

            else
            {
                AlterarVeiculo.Placa = Convert.ToString(txtPLACA_Alterar_Frotas.Text);
                AlterarVeiculo.Ano = Convert.ToInt32(txtANO_Alterar_Frotas.Text);
                AlterarVeiculo.Marca = txtMARCA_Alterar_Frotas.Text;
                AlterarVeiculo.Modelo = txtMODELO_Alterar_Frotas.Text;
                AlterarVeiculo.Consumo = txtCONSUMO_Alterar_Frotas.Text;
                AlterarVeiculo.Tipo = txtTIPO_Alterar_Frotas.Text;
                AlterarVeiculo.Disponibilidade = txtDISPONIBILIDADE_Alterar_Frotas.Text;
                clsAddVeiculoBll.Alterar(AlterarVeiculo);

                MessageBox.Show("Veiculo Alterado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CarregarGrid();
        }

        private void FormatarGrid()
        {
            AlterarGridVEICULO.ReadOnly = true;
            AlterarGridVEICULO.ScrollBars = ScrollBars.Vertical;

            AlterarGridVEICULO.Columns[0].HeaderText = "PLACA";
            AlterarGridVEICULO.Columns[3].HeaderText = "MARCA";
            AlterarGridVEICULO.Columns[2].HeaderText = "MODELO";
            AlterarGridVEICULO.Columns[1].HeaderText = "ANO";
            AlterarGridVEICULO.Columns[4].HeaderText = "CONSUMO";
            AlterarGridVEICULO.Columns[5].HeaderText = "TIPO";
            AlterarGridVEICULO.Columns[6].HeaderText = "DISPONIBILIDADE";

            AlterarGridVEICULO.Columns[0].Width = 120;
            AlterarGridVEICULO.Columns[1].Width = 100;
            AlterarGridVEICULO.Columns[2].Width = 150;
            AlterarGridVEICULO.Columns[3].Width = 150;
            AlterarGridVEICULO.Columns[4].Width = 150;
            AlterarGridVEICULO.Columns[5].Width = 150;
            AlterarGridVEICULO.Columns[6].Width = 170;
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)

        {
            AlterarGridVEICULO.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    AlterarGridVEICULO.DataSource = clsAddVeiculoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        AlterarGridVEICULO.DataSource = clsAddVeiculoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            AlterarGridVEICULO.DataSource = clsAddVeiculoBll.ObterDados(2, filtro);
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

        private void LimparCampos()
        {
            txtPLACA_Alterar_Frotas.Text = "";
            txtMODELO_Alterar_Frotas.Text = "";
            txtMARCA_Alterar_Frotas.Text = "";
            txtTIPO_Alterar_Frotas.Text = "";
            txtANO_Alterar_Frotas.Text = "";
            txtDISPONIBILIDADE_Alterar_Frotas.Text = "";
            txtCONSUMO_Alterar_Frotas.Text = "";
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = AlterarGridVEICULO.CurrentRow.Index;

            txtPLACA_Alterar_Frotas.Text = AlterarGridVEICULO[0, linhaSelecionada].Value.ToString();
            txtANO_Alterar_Frotas.Text = AlterarGridVEICULO[1, linhaSelecionada].Value.ToString();
            txtMARCA_Alterar_Frotas.Text = AlterarGridVEICULO[2, linhaSelecionada].Value.ToString();
            txtMODELO_Alterar_Frotas.Text = AlterarGridVEICULO[3, linhaSelecionada].Value.ToString();
            txtCONSUMO_Alterar_Frotas.Text = AlterarGridVEICULO[4, linhaSelecionada].Value.ToString();
            txtTIPO_Alterar_Frotas.Text = AlterarGridVEICULO[5, linhaSelecionada].Value.ToString();
            txtDISPONIBILIDADE_Alterar_Frotas.Text = AlterarGridVEICULO[6, linhaSelecionada].Value.ToString();
        }

        private void AlterarGridVEICULO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void btn_Voltar_Alterar_Veiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alterar_Veiculo_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
