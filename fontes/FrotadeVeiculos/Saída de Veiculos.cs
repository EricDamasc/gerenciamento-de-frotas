using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Entradas_de_Veiculos : Form
    {
        private clsSaidadeVeiculoDto _saidaDto;
        private clsSaidadeVeiculoBll _saidaBll;
       
        public Entradas_de_Veiculos()
        {
            InitializeComponent();

            /* Instanciação dos 
             * objetos privados */
            _saidaDto = new clsSaidadeVeiculoDto();
            _saidaBll = new clsSaidadeVeiculoBll();
            CarregarGrid();


        }

        private void btn_ADD_SAIDA_MOTORISTA_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CODIGO_Cliente_ADD_SAIDA.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Cliente!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_CODIGO_Motorista_ADD_SAIDA.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Motorista!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_DATA_ADD_SAIDA.Text == String.Empty)
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
                        _saidaDto.Saida = 0;
                        _saidaDto.IdMotorista = Convert.ToInt32(txt_CODIGO_Motorista_ADD_SAIDA.SelectedValue.ToString());
                        _saidaDto.Cliente = Convert.ToInt32(txt_CODIGO_Cliente_ADD_SAIDA.SelectedValue.ToString());
                        _saidaDto.DataSaida = Convert.ToDateTime(txt_DATA_ADD_SAIDA.Text);
                        //_saidaDto.DataChegada =Convert.ToDateTime(txt_DATA_ADD_SAIDA.Text);
                            
                        _saidaBll.Inserir(_saidaDto);
          
                        MessageBox.Show(
                            "Registro inserido com sucesso!",
                            "Alerta",
                            MessageBoxButtons.OK);

                        CarregarGrid(0, "");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
        }

        private void btn_Voltar_SAIDA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private DataTable CarregarMotorista()
        {
            return Conexao.obterDados("select idmotorista, nome " +
                                      "  from tblmotorista" +
                                      " ORDER BY nome ASC");
        }

        private DataTable CarregarClientes()
        {
            return Conexao.obterDados("SELECT idcliente, empresa  " +
                                   "  FROM tblcliente " +
                                   " ORDER BY empresa ASC");

        }

        private void CarregarCombo()
        {
            //_listaCursos = _cursoBll.ObterDados(0, string.Empty);
            txt_CODIGO_Cliente_ADD_SAIDA.DataSource = CarregarClientes();

            txt_CODIGO_Cliente_ADD_SAIDA.DisplayMember = "empresa";
            txt_CODIGO_Cliente_ADD_SAIDA.ValueMember = "idcliente";

            txt_CODIGO_Motorista_ADD_SAIDA.DataSource = CarregarMotorista();

            txt_CODIGO_Motorista_ADD_SAIDA.DisplayMember = "nome";
            txt_CODIGO_Motorista_ADD_SAIDA.ValueMember = "idmotorista";
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            GRID_SaidaVeiculo.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    GRID_SaidaVeiculo.DataSource = _saidaBll.obterdadosaida(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GRID_SaidaVeiculo.DataSource = _saidaBll.obterdadosaida(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GRID_SaidaVeiculo.DataSource = _saidaBll.obterdadosaida(2, filtro);
                        }
                    }
                    //FormatarGrid();
                }
            }

            catch
            {
                throw;
            }
        }

        private void FormatarGrid()
        {
            GRID_SaidaVeiculo.ReadOnly = true;
            GRID_SaidaVeiculo.ScrollBars = ScrollBars.Vertical;


            GRID_SaidaVeiculo.Columns[0].HeaderText = "CÓDIGO";
            GRID_SaidaVeiculo.Columns[1].HeaderText = "MOTORISTA";
            GRID_SaidaVeiculo.Columns[2].HeaderText = "CLIENTE";
            GRID_SaidaVeiculo.Columns[3].HeaderText = "SAÍDA";

            GRID_SaidaVeiculo.Columns[0].Width = 170;
            GRID_SaidaVeiculo.Columns[1].Width = 200;
            GRID_SaidaVeiculo.Columns[2].Width = 200;
            GRID_SaidaVeiculo.Columns[3].Width = 240;
        }

        private void Entradas_de_Veiculos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarCombo();
            FormatarGrid();
        }

        private void LimparCampos()
        {
            txt_CODIGO_ADD_Saida.Text = "";
            txt_CODIGO_Cliente_ADD_SAIDA.Text = "";
            txt_CODIGO_Motorista_ADD_SAIDA.Text = "";
            txt_DATA_ADD_SAIDA.Text = "";
        }

        private void btnLIMPAR_CAMPO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
