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
    public partial class Multas : Form
    {
        private clsMultasDto _multasDto;
        private clsMultasBll _multasBll;
        private List<clsMultasDto> _listaCidades;

        public Multas()
        {
            InitializeComponent();


            /* Instanciação dos 
             * objetos privados */
            _multasDto = new clsMultasDto();
            _multasBll = new clsMultasBll();
            _listaCidades = new List<clsMultasDto>();
        }

        private void btn_ADD_Abastecimento_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMOTORISTA_Cadastro_de_Multas.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Motorista!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtPLACA_Cadastro_de_Multas.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Placa!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtVALOR_Cadastro_de_Multas.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Valor!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtVENCIMENTO_Cadastro_de_Multas.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Vencimento!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _multasDto.idinfracao = 0;
                        _multasDto.idmotorista = Convert.ToInt32(txtMOTORISTA_Cadastro_de_Multas.SelectedValue.ToString());
                        _multasDto.Placa = txtPLACA_Cadastro_de_Multas.Text;
                        _multasDto.Valor = Convert.ToDecimal(txtVALOR_Cadastro_de_Multas.Text);
                        _multasDto.Vencimento =Convert.ToDateTime(txtVENCIMENTO_Cadastro_de_Multas.Text);

                        _multasBll.Inserir(_multasDto);
               
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

        private DataTable CarregarMotorista()
        {
            return Conexao.obterDados("select idmotorista, nome " +
                                      "  from tblmotorista" +
                                      " ORDER BY nome ASC");
        }

        private void CarregarCombo()
        {
            //_listaCursos = _cursoBll.ObterDados(0, string.Empty);
            txtPLACA_Cadastro_de_Multas.DataSource = CarregarPlacas();

            txtPLACA_Cadastro_de_Multas.DisplayMember = "placa";
            txtPLACA_Cadastro_de_Multas.ValueMember = "placa";

            txtMOTORISTA_Cadastro_de_Multas.DataSource = CarregarMotorista();

            txtMOTORISTA_Cadastro_de_Multas.DisplayMember = "nome";
            txtMOTORISTA_Cadastro_de_Multas.ValueMember = "idmotorista";
        }

        private void Multas_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }
    }
}
