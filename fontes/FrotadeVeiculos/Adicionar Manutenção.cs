using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using bll;
using dto;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dal;

namespace wf_FrotadeVeiculos
{
    public partial class Adcionar_Manutenção : Form
    {
        private clsAdicionarManutencaoDto _manutencaoDto;
        private clsAdicionarManutencaBll _manutencaoBll;

        public Adcionar_Manutenção()
        {
            InitializeComponent();

            /* Instanciação dos 
             * objetos privados */
            _manutencaoDto = new clsAdicionarManutencaoDto();
            _manutencaoBll = new clsAdicionarManutencaBll();
        }

        private void btn_ADD_MANUTENÇÃO_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_PECA_ADD_Manutenção.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma Peça!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_TIPOMANU_ADD_Manutenção.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Tipo de Manuntenção!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_PLACA_ADD_Manutenção.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma Placa!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_DATA_ADD_Manutenção.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma Data!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }

                else if (txt_PROBLEMAS_ADD_Manutenção.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Problema!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }

                else
                {
                    if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _manutencaoDto.ODS = 0;
                        _manutencaoDto.idPeca = Convert.ToInt32(txt_PECA_ADD_Manutenção.SelectedValue.ToString());
                        _manutencaoDto.Placa = txt_PLACA_ADD_Manutenção.Text;
                        _manutencaoDto.Problemas = txt_PROBLEMAS_ADD_Manutenção.Text;
                        _manutencaoDto.DatadeManu = Convert.ToDateTime(txt_DATA_ADD_Manutenção.Text);
                        _manutencaoDto.TipoManutencao = txt_TIPOMANU_ADD_Manutenção.Text;

                        _manutencaoBll.Inserir(_manutencaoDto);

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

        private void btn_VOLTAR_Abastecimento_Click(object sender, EventArgs e)
        {
            Close();
        }

        private DataTable CarregarPlacas()
        {
            return Conexao.obterDados("SELECT placa  " +
                                   "  FROM tblveiculo " +
                                   " ORDER BY placa ASC");

        }

        private DataTable CarregarPeca()
        {
            return Conexao.obterDados("select idpeca, peca " +
                                      "  from tblpeca" +
                                      " ORDER BY peca ASC");
        }

        private void CarregarCombo()
        {
            //_listaCursos = _cursoBll.ObterDados(0, string.Empty);
            txt_PLACA_ADD_Manutenção.DataSource = CarregarPlacas();

            txt_PLACA_ADD_Manutenção.DisplayMember = "placa";
            txt_PLACA_ADD_Manutenção.ValueMember = "placa";

            txt_PECA_ADD_Manutenção.DataSource = CarregarPeca();

            txt_PECA_ADD_Manutenção.DisplayMember = "peca";
            txt_PECA_ADD_Manutenção.ValueMember = "idpeca";
        }

        private void Adcionar_Manutenção_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        private void btn_VOLTAR_ADD_MANUTENÇÃO_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
