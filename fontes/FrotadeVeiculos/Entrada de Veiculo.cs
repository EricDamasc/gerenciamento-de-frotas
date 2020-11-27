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
    public partial class Entrada_de_Veiculo : Form
    {
        private clsEntradadeVeiculoDto _entradaDto;
        private clsEntradadeVeiculoBll _entradaBll;

        public Entrada_de_Veiculo()
        {
            InitializeComponent();
            _entradaDto = new clsEntradadeVeiculoDto();
            _entradaBll = new clsEntradadeVeiculoBll();
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
            txt_CODIGO_Cliente_ADD_Entrada.DataSource = CarregarClientes();

            txt_CODIGO_Cliente_ADD_Entrada.DisplayMember = "empresa";
            txt_CODIGO_Cliente_ADD_Entrada.ValueMember = "idcliente";

            txt_CODIGO_Motorista_ADD_Entrada.DataSource = CarregarMotorista();

            txt_CODIGO_Motorista_ADD_Entrada.DisplayMember = "nome";
            txt_CODIGO_Motorista_ADD_Entrada.ValueMember = "idmotorista";
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
            CarregarGridENTRADA(0, "");
        }

        //private void CarregarGrid(int tipo, String filtro)
        //{
        //    GRID_ENTRADA.AutoGenerateColumns = true;

        //    // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
        //    try
        //    {
        //        if (tipo == 0)
        //        {
        //            GRID_ENTRADA.DataSource = _entradaBll.ObterDados(0, String.Empty);
        //        }
        //        else
        //        {
        //            if (tipo == 1)
        //            {
        //                GRID_ENTRADA.DataSource = _entradaBll.ObterDados(1, filtro);
        //            }
        //            else
        //            {
        //                if (tipo == 2)
        //                {
        //                    GRID_ENTRADA.DataSource = _entradaBll.ObterDados(2, filtro);
        //                }
        //            }
        //        }
        //    }

        //    catch
        //    {
        //        throw;
        //    }
        //    FormatarGrid();
        //    //FormatarGrid2();
        //}

        private void CarregarGrid(int tipo, string filtro)
        {
            GRID_ENTRADA.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_ENTRADA.DataSource = _entradaBll.ObterdadosNOVO(0, String.Empty);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormatarGrid();
        }

        private void CarregarGridENTRADA(int tipo, string filtro)
        {
            GRID_ENTRADA_2.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GRID_ENTRADA_2.DataSource = _entradaBll.Obterdados(0, String.Empty);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormatarGrid2();
        }

        private void FormatarGrid()
        {
            GRID_ENTRADA.ReadOnly = true;
            GRID_ENTRADA.ScrollBars = ScrollBars.Vertical;


            GRID_ENTRADA.Columns[0].HeaderText = "CÓD.SAÍDA";
            GRID_ENTRADA.Columns[1].HeaderText = "MOTORISTA";
            GRID_ENTRADA.Columns[2].HeaderText = "CLIENTE";
            GRID_ENTRADA.Columns[3].HeaderText = "DATA SAÍDA";

            GRID_ENTRADA.Columns[0].Width = 120;
            GRID_ENTRADA.Columns[1].Width = 120;
            GRID_ENTRADA.Columns[2].Width = 120;
            GRID_ENTRADA.Columns[3].Width = 140;
        }

        private void FormatarGrid2()
        {
            GRID_ENTRADA_2.ReadOnly = true;
            GRID_ENTRADA_2.ScrollBars = ScrollBars.Vertical;

            GRID_ENTRADA_2.Columns[0].HeaderText = "CÓD.SAÍDA";
            GRID_ENTRADA_2.Columns[1].HeaderText = "DATA ENTRADA";

            GRID_ENTRADA_2.Columns[0].Width = 150;
            GRID_ENTRADA_2.Columns[1].Width = 200;
        }

        private void Entradas_de_Veiculos_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        private void LimparCampos()
        {
            txt_CODIGO_ADD_Entrada.Text = "";
            txt_CODIGO_Cliente_ADD_Entrada.Text = "";
            txt_CODIGO_Motorista_ADD_Entrada.Text = "";
            txt_DATA_ADD_SAIDA.Text = "";
        }

        private void btnLIMPAR_CAMPO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void AtualizarGrid()
        {
            Int32 linhaSelecionada;

            linhaSelecionada = GRID_ENTRADA.CurrentRow.Index;

            txt_CODIGO_ADD_Entrada.Text = GRID_ENTRADA[0, linhaSelecionada].Value.ToString();
            txt_CODIGO_Cliente_ADD_Entrada.Text = GRID_ENTRADA[1, linhaSelecionada].Value.ToString();
            txt_CODIGO_Motorista_ADD_Entrada.Text = GRID_ENTRADA[2, linhaSelecionada].Value.ToString();
            txt_DATA_ADD_SAIDA.Text = GRID_ENTRADA[3, linhaSelecionada].Value.ToString();
        }

        private void GRID_ENTRADA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void Entrada_de_Veiculo_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarCombo();
            
        }

        private void btn_Voltar_ENTRADA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ADD_ENTRADA_MOTORISTA_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CODIGO_ADD_Entrada.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Cliente!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_CODIGO_Motorista_ADD_Entrada.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Motorista!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txt_CODIGO_Cliente_ADD_Entrada.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Cliente!",
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
                        _entradaDto.Saida = Convert.ToInt32(txt_CODIGO_ADD_Entrada.Text);
                        _entradaDto.DataChegada = Convert.ToDateTime(txt_DATA_Motorista_ADD_Entrada.Text);

                        _entradaBll.Inserir(_entradaDto);

                        MessageBox.Show(
                            "Registro inserido com sucesso!",
                            "Alerta",
                            MessageBoxButtons.OK);

                        CarregarGridENTRADA(0, "");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
        }
    }
}
