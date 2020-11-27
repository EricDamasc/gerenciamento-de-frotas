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
    public partial class Locação : Form
    {
        private clsLocacaoDto _locacaoDto;
        private clsLocacaoBll _locacaoBll;

        public Locação()
        {
            InitializeComponent();
            _locacaoDto = new clsLocacaoDto();
            _locacaoBll = new clsLocacaoBll();
        }

        private void btn_ADD_Locacao_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDATA_Cadastro_de_Locacao.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma Data!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtPLACA_Cadastro_de_Locacao.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Placa!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtVALOR_Cadastro_de_Locacao.Text == String.Empty)
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
                        _locacaoDto.IdLocacao = 0;
                        _locacaoDto.DatadeLocacao = Convert.ToDateTime(txtDATA_Cadastro_de_Locacao.Text);
                        _locacaoDto.Placa = txtPLACA_Cadastro_de_Locacao.SelectedValue.ToString();
                        _locacaoDto.Valorlocacao = Convert.ToDecimal(txtVALOR_Cadastro_de_Locacao.Text);
                  
                        _locacaoBll.Inserir(_locacaoDto);

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
            txtPLACA_Cadastro_de_Locacao.DataSource = CarregarPlacas();

            txtPLACA_Cadastro_de_Locacao.DisplayMember = "placa";
            txtPLACA_Cadastro_de_Locacao.ValueMember = "placa";
        }

        private void Locação_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        private void btn_VOLTAR_Locacao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
