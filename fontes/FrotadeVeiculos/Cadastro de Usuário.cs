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
    public partial class Cadastro_de_Usuário : Form
    {
        private clsUsuarioBll clsUsuarioBll = new clsUsuarioBll();
        private clsUsuarioDto usuario = new clsUsuarioDto();

        public Cadastro_de_Usuário()
        {
            InitializeComponent();
        }

        private void btn_VOLTAR_Cadastro_Usuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Nova_Senha_Cadastro_Usuario_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO CPF
            if (txtCPF_Cadastro_Usuario.Text == "")
            {
                MessageBox.Show("O campo CPF é obrigatório");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO ANO
            else if (txtEMAIL_Cadastro_Usuario.Text == "")
            {
                MessageBox.Show("O EMAIL é obrigatório");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO SENHA
            if (txtSENHA_Cadastro_Usuario.Text == "")
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                Focus();
            }
            // COINFIRMAÇÃO DE SENHA
            if (txtSENHA_Cadastro_Usuario.Text != txtSENHAVALIDAR_Cadastro_Usuario.Text)
            {
                MessageBox.Show("A senha não Coincidem");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO PERFIL
            else if (txtPERFIL_Cadastro_Usuario.Text == "")
            {
                MessageBox.Show("O PERFIL é obrigatório");
                Focus();
            }

            else
            {
                usuario.CPF = txtCPF_Cadastro_Usuario.Text;
                usuario.Perfil = txtPERFIL_Cadastro_Usuario.Text;
                usuario.Email = txtEMAIL_Cadastro_Usuario.Text;
                usuario.Senha = txtSENHA_Cadastro_Usuario.Text;

                clsUsuarioBll.Inserir(usuario);

                MessageBox.Show("USUÁRIO inserido com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimparCampos()
        {
            txtCPF_Cadastro_Usuario.Text = "";
            txtEMAIL_Cadastro_Usuario.Text = "";
            txtPERFIL_Cadastro_Usuario.Text = "";
            txtSENHA_Cadastro_Usuario.Text = "";
        }
    }
}
