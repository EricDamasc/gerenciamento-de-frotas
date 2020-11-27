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
    public partial class Alterar_Motorista : Form
    {
        private clsMotoristasBll clsMotoristasBll = new clsMotoristasBll();
        private clsMotoristasDto Motorista = new clsMotoristasDto();

        public Alterar_Motorista()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_Alterar_MOTORISTA_Click(object sender, EventArgs e)
        {
              // VALIDAÇÃO DO CAMPO CPF
            if (txtCPF_Alterar_Motorista.Text == "")
            {
                MessageBox.Show("O campo CPF é obrigatório");
                txtCPF_Alterar_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO NOME
            else if (txtNOME_Alterar_Motorista.Text == "")
            {
                MessageBox.Show("O NOME é obrigatório");
                txtNOME_Alterar_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO RG
            if (txtRG_Alterar_Motorista.Text == "")
            {
                MessageBox.Show("O campo RG é obrigatório");
                txtRG_Alterar_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO CNH
            else if (txtCNH_Alterar_Motorista.Text == "")
            {
                MessageBox.Show("O CNH é obrigatório");
                txtCNH_Alterar_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE CNH
            else if (txtTIPOCNH_Alterar_Motorista.Text == "")
            {
                MessageBox.Show("O TIPO DE CNH é obrigatório");
                txtTIPOCNH_Alterar_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO VALIDADE CNH
            if (txtVALIDADECNH_Alterar_Motorista.Text == "")
            {
                MessageBox.Show("O campo VALIDADE CNH é obrigatório");
                txtVALIDADECNH_Alterar_Motorista.Focus();
            }

            else
            {
                Motorista.IdMotorista = Convert.ToInt32(txtID_Alterar_Motorista.Text);
                Motorista.Nome = txtNOME_Alterar_Motorista.Text;
                Motorista.CPF = txtCPF_Alterar_Motorista.Text;
                Motorista.RG = txtRG_Alterar_Motorista.Text;
                Motorista.TipoCNH = txtTIPOCNH_Alterar_Motorista.Text;
                Motorista.Nascimento = txtDATANASC_Alterar_Motorista.Text;
                Motorista.NumCNH = txtCNH_Alterar_Motorista.Text;
                Motorista.ValidadeCNH = txtVALIDADECNH_Alterar_Motorista.Text;

                clsMotoristasBll.Alterar(Motorista);

                MessageBox.Show("Motorista Alterado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

            CarregarGrid();
        }
        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            AlterarGridMOTORISTA.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    AlterarGridMOTORISTA.DataSource = clsMotoristasBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        AlterarGridMOTORISTA.DataSource = clsMotoristasBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            AlterarGridMOTORISTA.DataSource = clsMotoristasBll.ObterDados(2, filtro);
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
            AlterarGridMOTORISTA.ReadOnly = true;
            AlterarGridMOTORISTA.ScrollBars = ScrollBars.Vertical;


            AlterarGridMOTORISTA.Columns[0].HeaderText = "CÓDIGO";
            AlterarGridMOTORISTA.Columns[1].HeaderText = "RG";
            AlterarGridMOTORISTA.Columns[2].HeaderText = "CPF";
            AlterarGridMOTORISTA.Columns[3].HeaderText = "NOME";
            AlterarGridMOTORISTA.Columns[4].HeaderText = "NASCIMENTO";
            AlterarGridMOTORISTA.Columns[5].HeaderText = "NUM. CNH";
            AlterarGridMOTORISTA.Columns[6].HeaderText = "TIPO CNH";
            AlterarGridMOTORISTA.Columns[7].HeaderText = "VALIDADE CNH";

            AlterarGridMOTORISTA.Columns[0].Width = 60;
            AlterarGridMOTORISTA.Columns[1].Width = 100;
            AlterarGridMOTORISTA.Columns[2].Width = 120;
            AlterarGridMOTORISTA.Columns[3].Width = 210;
            AlterarGridMOTORISTA.Columns[4].Width = 150;
            AlterarGridMOTORISTA.Columns[5].Width = 150;
            AlterarGridMOTORISTA.Columns[6].Width = 90;
            AlterarGridMOTORISTA.Columns[7].Width = 150;
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = AlterarGridMOTORISTA.CurrentRow.Index;

            txtID_Alterar_Motorista.Text = AlterarGridMOTORISTA[0, linhaSelecionada].Value.ToString();
            txtRG_Alterar_Motorista.Text = AlterarGridMOTORISTA[1, linhaSelecionada].Value.ToString();
            txtCPF_Alterar_Motorista.Text = AlterarGridMOTORISTA[2, linhaSelecionada].Value.ToString();
            txtNOME_Alterar_Motorista.Text = AlterarGridMOTORISTA[3, linhaSelecionada].Value.ToString();
            txtDATANASC_Alterar_Motorista.Text = AlterarGridMOTORISTA[4, linhaSelecionada].Value.ToString();
            txtCNH_Alterar_Motorista.Text = AlterarGridMOTORISTA[5, linhaSelecionada].Value.ToString();
            txtTIPOCNH_Alterar_Motorista.Text = AlterarGridMOTORISTA[6, linhaSelecionada].Value.ToString();
            txtVALIDADECNH_Alterar_Motorista.Text = AlterarGridMOTORISTA[7, linhaSelecionada].Value.ToString();
        }

        private void LimparCampos()
        {
            txtNOME_Alterar_Motorista.Text = "";
            txtTIPOCNH_Alterar_Motorista.Text = "";
            txtVALIDADECNH_Alterar_Motorista.Text = "";
        }

        private void btn_Voltar_Alterar_Motorista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLIMPAR_CAMPO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void AlterarGridMOTORISTA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void Alterar_Motorista_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
