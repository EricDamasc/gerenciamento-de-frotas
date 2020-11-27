using bll;
using dto;
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

namespace wf_FrotadeVeiculos
{
    public partial class Motorista_Próprio : Form
    {
        private clsMotoristasBll clsMotoristasBll = new clsMotoristasBll();
        private clsMotoristasDto Motorista = new clsMotoristasDto();

        public Motorista_Próprio()
        {
            InitializeComponent();
        }

        private void btn_ADD_MOTORISTA_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO CPF
            if (txtCPF_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O campo CPF é obrigatório");
                txtCPF_Cadastro_de_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO NOME
            else if (txtNOME_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O NOME é obrigatório");
                txtNOME_Cadastro_de_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO RG
            if (txtRG_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O campo RG é obrigatório");
                txtRG_Cadastro_de_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO CNH
            else if (txtCNH_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O CNH é obrigatório");
                txtCNH_Cadastro_de_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO NASCIMENTO
            if (txtDATA_NASC_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O campo DATA DE NASCIMENTO é obrigatório");
                txtDATA_NASC_Cadastro_de_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE CNH
            else if (txtTIPOCNH_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O TIPO DE CNH é obrigatório");
                txtTIPOCNH_Cadastro_de_Motorista.Focus();
            }
            // VALIDAÇÃO DO CAMPO VALIDADE CNH
            if (txtVALIDADECNH_Cadastro_de_Motorista.Text == "")
            {
                MessageBox.Show("O campo VALIDADE CNH é obrigatório");
            }

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Motorista.Nome = txtNOME_Cadastro_de_Motorista.Text;
                Motorista.CPF = (txtCPF_Cadastro_de_Motorista.Text);
                Motorista.Nascimento =txtDATA_NASC_Cadastro_de_Motorista.Text;
                Motorista.TipoCNH = txtTIPOCNH_Cadastro_de_Motorista.Text;
                Motorista.RG = (txtRG_Cadastro_de_Motorista.Text);
                Motorista.NumCNH = txtCNH_Cadastro_de_Motorista.Text;
                Motorista.ValidadeCNH = txtVALIDADECNH_Cadastro_de_Motorista.Text;

                clsMotoristasBll.Inserir(Motorista);

                MessageBox.Show("Motorista inserido com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparCampos()
        {
            txtCNH_Cadastro_de_Motorista.Text = "";
            txtCPF_Cadastro_de_Motorista.Text = "";
            txtDATA_NASC_Cadastro_de_Motorista.Text = "";
            txtNOME_Cadastro_de_Motorista.Text = "";
            txtRG_Cadastro_de_Motorista.Text = "";
            txtTIPOCNH_Cadastro_de_Motorista.Text = "";
            txtVALIDADECNH_Cadastro_de_Motorista.Text = "";
        }

        private void btn_VOLTAR_MOTORISTA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
