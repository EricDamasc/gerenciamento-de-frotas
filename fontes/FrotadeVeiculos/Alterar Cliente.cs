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
    public partial class Alterar_Cliente : Form
    {
        private clsClienteBll clsClienteBll = new clsClienteBll();
        private clsClienteDto AlterarCliente = new clsClienteDto();

        public Alterar_Cliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_Alterar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAÇÃO DO CAMPO CODIGO
                if (txtCODIGO_Alterar_Cliente.Text == "")
                {
                    MessageBox.Show("O campo PLACA é obrigatório");
                    txtCODIGO_Alterar_Cliente.Focus();
                }
                // VALIDAÇÃO DO CAMPO EMPRESA
                else if (txtEMPRESA_Alterar_Cliente.Text == "")
                {
                    MessageBox.Show("O nome da EMPRESA é obrigatório");
                    txtEMPRESA_Alterar_Cliente.Focus();
                }
                // VALIDAÇÃO DO CAMPO TELEFONE
                if (txtTELEFONE_Alterar_Cliente.Text == "")
                {
                    MessageBox.Show("O campo TELEFONE é obrigatório");
                    txtTELEFONE_Alterar_Cliente.Focus();
                }
                // VALIDAÇÃO DO CAMPO E-MAIL
                else if (txtEMAIL_Alterar_Cliente.Text == "")
                {
                    MessageBox.Show("O E-MAIL é obrigatório");
                    txtEMAIL_Alterar_Cliente.Focus();
                }
                // VALIDAÇÃO DO CAMPO CNPJ
                if (txtCNPJ_ALTERAR_Cliente.Text == "")
                {
                    MessageBox.Show("O campo CNPJ é obrigatório");
                    txtCNPJ_ALTERAR_Cliente.Focus();
                }

                else
                {
                    if (MessageBox.Show("Confirma a Alteração?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AlterarCliente.Cliente = Convert.ToInt32(txtCODIGO_Alterar_Cliente.Text);
                        AlterarCliente.Empresa = txtEMPRESA_Alterar_Cliente.Text;
                        AlterarCliente.Telefone = txtTELEFONE_Alterar_Cliente.Text;
                        AlterarCliente.CNPJ = txtCNPJ_ALTERAR_Cliente.Text;
                        AlterarCliente.Email = txtEMAIL_Alterar_Cliente.Text;
                        AlterarCliente.CEP = txtCEP_Alterar_Cliente.Text;
                        AlterarCliente.Estados = txtESTADOS_Altrerar_Cliente.Text;

                        clsClienteBll.Alterar(AlterarCliente);

                        MessageBox.Show("Cliente Alterado com sucesso!", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CarregarGrid();
                }
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
            AlterarGridCLIENTE.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    AlterarGridCLIENTE.DataSource = clsClienteBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        AlterarGridCLIENTE.DataSource = clsClienteBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            AlterarGridCLIENTE.DataSource = clsClienteBll.ObterDados(2, filtro);
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
            AlterarGridCLIENTE.ReadOnly = true;
            AlterarGridCLIENTE.ScrollBars = ScrollBars.Vertical;


            AlterarGridCLIENTE.Columns[0].HeaderText = "CÓDIGO";
            AlterarGridCLIENTE.Columns[1].HeaderText = "TELEFONE";
            AlterarGridCLIENTE.Columns[3].HeaderText = "CNPJ";
            AlterarGridCLIENTE.Columns[2].HeaderText = "EMPRESA";
            AlterarGridCLIENTE.Columns[4].HeaderText = "E-MAIL";
            AlterarGridCLIENTE.Columns[5].HeaderText = "CEP";
            AlterarGridCLIENTE.Columns[6].HeaderText = "ESTADOS";

            AlterarGridCLIENTE.Columns[0].Width = 60;
            AlterarGridCLIENTE.Columns[1].Width = 100;
            AlterarGridCLIENTE.Columns[2].Width = 260;
            AlterarGridCLIENTE.Columns[3].Width = 150;
            AlterarGridCLIENTE.Columns[4].Width = 300;
            AlterarGridCLIENTE.Columns[5].Width = 65;
            AlterarGridCLIENTE.Columns[6].Width = 160;
        }

        private void LimparCampos()
        {
            txtCODIGO_Alterar_Cliente.Text = "";
            txtEMAIL_Alterar_Cliente.Text = "";
            txtEMPRESA_Alterar_Cliente.Text = "";
            txtTELEFONE_Alterar_Cliente.Text = "";
            txtCNPJ_ALTERAR_Cliente.Text = "";
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = AlterarGridCLIENTE.CurrentRow.Index;

            txtCODIGO_Alterar_Cliente.Text = AlterarGridCLIENTE[0, linhaSelecionada].Value.ToString();
            txtTELEFONE_Alterar_Cliente.Text = AlterarGridCLIENTE[1, linhaSelecionada].Value.ToString();
            txtEMPRESA_Alterar_Cliente.Text = AlterarGridCLIENTE[2, linhaSelecionada].Value.ToString();
            txtCNPJ_ALTERAR_Cliente.Text = AlterarGridCLIENTE[3, linhaSelecionada].Value.ToString();
            txtEMAIL_Alterar_Cliente.Text = AlterarGridCLIENTE[4, linhaSelecionada].Value.ToString();
            txtCEP_Alterar_Cliente.Text = AlterarGridCLIENTE[5, linhaSelecionada].Value.ToString();
            txtESTADOS_Altrerar_Cliente.Text = AlterarGridCLIENTE[6, linhaSelecionada].Value.ToString();
        }

        private void AlterarGridCLIENTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void btn_Voltar_Alterar_Cliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLIMPAR_CAMPO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void AlterarGridCLIENTE_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void Alterar_Cliente_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}