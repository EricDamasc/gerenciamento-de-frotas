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
    public partial class Cliente_ : Form
    {
        private clsClienteBll clienteBll = new clsClienteBll();
        private clsClienteDto AddCliente = new clsClienteDto();

        public Cliente_()
        {
            InitializeComponent();
        }

        private void btn_ADD_CLIENTE_Click(object sender, EventArgs e)
        { 
            // VALIDAÇÃO DO CAMPO CNPJ
            if (txtCNPJ_Cadastro_de_Cliente.Text == "")
            {
                MessageBox.Show("O campo CNPJ é obrigatório");
                txtCNPJ_Cadastro_de_Cliente.Focus();
            }
            // VALIDAÇÃO DO CAMPO EMPRESA
            else if (txtEMPRESA_Cadastro_de_Cliente.Text == "")
            {
                MessageBox.Show("O EMPRESA é obrigatório");
                txtEMPRESA_Cadastro_de_Cliente.Focus();
            }
            // VALIDAÇÃO DO CAMPO TELEFONE
            if (txtTELEFONE_Cadastro_de_Cliente.Text == "")
            {
                MessageBox.Show("O campo TELEFONE é obrigatório");
                txtTELEFONE_Cadastro_de_Cliente.Focus();
            }

            // VALIDAÇÃO DO CAMPO EMAIL
            else if (txtEMAIL_Cadastro_de_Cliente.Text == "")
            {
                MessageBox.Show("O campo EMAIL é obrigatório");
                txtEMAIL_Cadastro_de_Cliente.Focus();
            }
            // VALIDAÇÃO DO CAMPO CEP
            else if (txtCEP_Cadastro_de_Cliente.Text == "")
            {
                MessageBox.Show("O campo CEP é obrigatório");
                txtCEP_Cadastro_de_Cliente.Focus();
            }
            // VALIDAÇÃO DO CAMPO ESTADOS
            else if (txtESTADOS_Cadastro_de_Cliente.Text == "")
            {
                MessageBox.Show("O campo ESTADOS é obrigatório");
                txtESTADOS_Cadastro_de_Cliente.Focus();
            }

            else
            {
                //AddCliente.Cliente = Convert.ToInt32(txtIDCLIENTE_Cadastro_de_Cliente.Text);
                AddCliente.CNPJ = (txtCNPJ_Cadastro_de_Cliente.Text);
                AddCliente.Empresa = txtEMPRESA_Cadastro_de_Cliente.Text;
                AddCliente.Telefone = (txtTELEFONE_Cadastro_de_Cliente.Text);
                AddCliente.Email = txtEMAIL_Cadastro_de_Cliente.Text;
                AddCliente.CEP = txtCEP_Cadastro_de_Cliente.Text;
                AddCliente.Estados = txtESTADOS_Cadastro_de_Cliente.Text;

                clienteBll.Inserir(AddCliente);

                MessageBox.Show("Cliente inserido com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparCampos()
        {
                txtIDCLIENTE_Cadastro_de_Cliente.Text = "";
                txtEMPRESA_Cadastro_de_Cliente.Text = "";
                txtTELEFONE_Cadastro_de_Cliente.Text = "";
                txtCNPJ_Cadastro_de_Cliente.Text = "";
                txtEMAIL_Cadastro_de_Cliente.Text = "";
        }

        private void btn_VOLTAR_CLIENTE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
