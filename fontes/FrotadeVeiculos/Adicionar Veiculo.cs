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
    public partial class Adicionar_Veiculo_Próprio : Form
    {
        private clsVeiculoBll AddVeiculoBll = new clsVeiculoBll();
        private clsVeiculoDto Veiculo = new clsVeiculoDto();

        public Adicionar_Veiculo_Próprio()
        {
            InitializeComponent();
        }

        private void btn_Novo_CarroPróprio_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAÇÃO DO CAMPO PLACA
                if (txtPLACA_Cadastro_de_Frotas.Text == "")
                {
                    MessageBox.Show("O campo PLACA é obrigatório");
                    LimparCampos();
                }
                // VALIDAÇÃO DO CAMPO ANO
                else if (cmb_Ano_Veiculo.Text == "")
                {
                    MessageBox.Show("O ANO é obrigatório");
                    LimparCampos();
                }
                // VALIDAÇÃO DO CAMPO MARCA
                if (txtMARCA_Cadastro_de_Frotas.Text == "")
                {
                    MessageBox.Show("O campo MARCA é obrigatório");
                    LimparCampos();
                }
                // VALIDAÇÃO DO CAMPO MODELO
                else if (txtModelo_Cadastro_de_Frotas.Text == "")
                {
                    MessageBox.Show("O MODELO é obrigatório");
                    LimparCampos();
                }
                // VALIDAÇÃO DO CAMPO CONSUMO
                if (txtCONSUMO_Cadastro_de_Frotas.Text == "")
                {
                    MessageBox.Show("O campo CONSUMO é obrigatório");
                    LimparCampos();
                }
                // VALIDAÇÃO DO CAMPO TIPO
                else if (txtTIPO_Cadastro_de_Frotas.Text == "")
                {
                    MessageBox.Show("O TIPO é obrigatório");
                    LimparCampos();
                }
                // VALIDAÇÃO DO CAMPO DISPONIBILIDADE
                if (txtDISPONIBILIDADE_Cadastro_de_Frotas.Text == "")
                {
                    MessageBox.Show("O campo DISPONIBILIDADE é obrigatório");
                    LimparCampos();
                }

                else
                {
                    Veiculo.Placa = Convert.ToString(txtPLACA_Cadastro_de_Frotas.Text);
                    Veiculo.Ano = Convert.ToInt32(cmb_Ano_Veiculo.Text);
                    Veiculo.Marca = txtMARCA_Cadastro_de_Frotas.Text;
                    Veiculo.Modelo = txtModelo_Cadastro_de_Frotas.Text;
                    Veiculo.Consumo = txtCONSUMO_Cadastro_de_Frotas.Text;
                    Veiculo.Tipo = txtTIPO_Cadastro_de_Frotas.Text;
                    Veiculo.Disponibilidade = txtDISPONIBILIDADE_Cadastro_de_Frotas.Text;

                    AddVeiculoBll.Inserir(Veiculo);

                    MessageBox.Show("Veiculo inserido com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LimparCampos()
        {
            txtPLACA_Cadastro_de_Frotas.Text = "";
            cmb_Ano_Veiculo.Text = "";
            txtMARCA_Cadastro_de_Frotas.Text = "";
            txtModelo_Cadastro_de_Frotas.Text = "";
            txtCONSUMO_Cadastro_de_Frotas.Text = "";
            txtTIPO_Cadastro_de_Frotas.Text = "";
            txtDISPONIBILIDADE_Cadastro_de_Frotas.Text = "";
        }   

        private void btn_VOLTAR_Cadastro_Frotas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLIMPAR_CAMPO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
