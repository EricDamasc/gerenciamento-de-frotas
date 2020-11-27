using bll;
using dal;
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

    public partial class Abastecimento : Form
    {
        private clsAbastecimentoDto _abastecimentoDto;
        private clsAbastecimentoBll _abastecimentoBll;

        public Abastecimento()
        {
            InitializeComponent();

            /* Instanciação dos 
             * objetos privados */
            _abastecimentoDto = new clsAbastecimentoDto();
            _abastecimentoBll = new clsAbastecimentoBll();
        }

        private void btn_ADD_Abastecimento_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPLACA_Cadastro_de_Abastecimento.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Placa!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtDATA_Cadastro_de_Abastecimento.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma Data!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtCOMBUSTIVEL_Cadastro_de_Abastecimento.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Combustivel!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtVALOR_Cadastro_de_Abastecimento.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Valor!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _abastecimentoDto.Abastecimento = 0;
                        _abastecimentoDto.Combustivel = (txtCOMBUSTIVEL_Cadastro_de_Abastecimento.Text.ToString());
                        _abastecimentoDto.Placa = txtPLACA_Cadastro_de_Abastecimento.SelectedValue.ToString();
                        _abastecimentoDto.Valor = Convert.ToDecimal(txtVALOR_Cadastro_de_Abastecimento.Text);
                        _abastecimentoDto.DatadeAbastecimento = Convert.ToDateTime(txtDATA_Cadastro_de_Abastecimento.Text);

                        _abastecimentoBll.Inserir(_abastecimentoDto);

                        MessageBox.Show(
                            "Registro inserido com sucesso!",
                            "Alerta",
                            MessageBoxButtons.OK);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
        }

        private DataTable CarregarPlacas()
        {
            return Conexao.obterDados("SELECT placa  " +
                                   "  FROM tblveiculo " +
                                   " ORDER BY placa ASC");

        }

        private void CarregarCombo()
        {
            //_listaCursos = _cursoBll.ObterDados(0, string.Empty);
            txtPLACA_Cadastro_de_Abastecimento.DataSource = CarregarPlacas();

            txtPLACA_Cadastro_de_Abastecimento.DisplayMember = "placa";
            txtPLACA_Cadastro_de_Abastecimento.ValueMember = "placa";
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        private void btn_VOLTAR_Abastecimento_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
