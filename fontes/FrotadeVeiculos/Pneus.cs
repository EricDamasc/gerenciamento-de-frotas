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
    public partial class Pneus : Form
    {
        private clsPneusBll _pneusBll = new clsPneusBll();
        private clsPneusDto _pneusDto = new clsPneusDto();
 
        public Pneus()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = CadastrarPneus_GRID.CurrentRow.Index;

            txtCODIGO_Cadastro_de_Pneus.Text = CadastrarPneus_GRID[0, linhaSelecionada].Value.ToString();
            txtMARCA_Cadastro_de_Pneus.Text = CadastrarPneus_GRID[1, linhaSelecionada].Value.ToString();
            txtTAMANHO_Cadastro_de_Pneus.Text = CadastrarPneus_GRID[2, linhaSelecionada].Value.ToString();
            txtVALOR_Cadastro_de_Pneus.Text = CadastrarPneus_GRID[3, linhaSelecionada].Value.ToString();
            txtOBS_Cadastro_de_Pneus.Text = CadastrarPneus_GRID[4, linhaSelecionada].Value.ToString();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            CadastrarPneus_GRID.AutoGenerateColumns = true;

      
            try
            {
                if (tipo == 0)
                {
                    CadastrarPneus_GRID.DataSource = _pneusBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        CadastrarPneus_GRID.DataSource = _pneusBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            CadastrarPneus_GRID.DataSource = _pneusBll.ObterDados(2, filtro);
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
            CadastrarPneus_GRID.ReadOnly = true;
            CadastrarPneus_GRID.ScrollBars = ScrollBars.Vertical;


            CadastrarPneus_GRID.Columns[0].HeaderText = "CÓDIGO";
            CadastrarPneus_GRID.Columns[1].HeaderText = "MARCA";
            CadastrarPneus_GRID.Columns[2].HeaderText = "TAMANHO";
            CadastrarPneus_GRID.Columns[3].HeaderText = "VALOR";
            CadastrarPneus_GRID.Columns[4].HeaderText = "OBSERVAÇÕES";
      
            CadastrarPneus_GRID.Columns[0].Width = 60;
            CadastrarPneus_GRID.Columns[1].Width = 180;
            CadastrarPneus_GRID.Columns[3].Width = 115;
            CadastrarPneus_GRID.Columns[2].Width = 115;
            CadastrarPneus_GRID.Columns[4].Width = 300;
        }

        private void btn_ADD_Pneus_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (txtVALOR_Cadastro_de_Pneus.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Valor!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtMARCA_Cadastro_de_Pneus.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma Marca!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtTAMANHO_Cadastro_de_Pneus.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Tamanho!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
        
                else
                {
                    if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _pneusDto.Pneu = 0;
                        _pneusDto.Preco = Convert.ToInt32(txtVALOR_Cadastro_de_Pneus.Text);
                        _pneusDto.Marca = txtMARCA_Cadastro_de_Pneus.Text;
                        _pneusDto.Tamanho = Convert.ToInt32(txtTAMANHO_Cadastro_de_Pneus.Text);
                        // _multasDto._idplaca = txtIDPLACA_Cadastro_de_Multas.Text;
                        _pneusDto.Observacao = Convert.ToString(txtOBS_Cadastro_de_Pneus.Text);
                        

                        _pneusBll.Inserir(_pneusDto);
                   
                        MessageBox.Show(
                            "Registro inserido com sucesso!",
                            "Alerta",
                            MessageBoxButtons.OK);
                    }
                    CarregarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }
        }

        private void btn_VOLTAR_Pneus_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarPneus_GRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //EXIBIR E ATUALIZAR GRID
            AtualizarGrid();
        }

        private void Pneus_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }
    }
}
