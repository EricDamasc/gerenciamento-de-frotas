using System;
using bll;
using dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dal;

namespace wf_FrotadeVeiculos
{
    public partial class Requisição_de_Manuntenção : Form
    {
        private clsSolicitacaoPneuDto _solicitarDto;
        private clsSolicitacaoPneuBll _solicitarBll;
        private List<clsSolicitacaoPneuDto> _listapneus;

        public Requisição_de_Manuntenção()
        {
            InitializeComponent();

            _solicitarDto = new clsSolicitacaoPneuDto();
            _solicitarBll = new clsSolicitacaoPneuBll();
            _listapneus = new List<clsSolicitacaoPneuDto>();
        }

        private void btn_VOLTAR_RequisitosMANU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ADD_SolicitacaoPNEU_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPNEUCOD_Cadastro_de_SolicitacaoPNEU.Text.Trim() == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um PNEU!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtPLACA_Cadastro_de_SolicitacaoPNEU.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe um Placa!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtQUANTIDADE_Cadastro_de_SolicitacaoPNEU.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe uma QUANTIDADE!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
                else if (txtDATA_Cadastro_de_SolicitacaoPNEU.Text == String.Empty)
                {
                    MessageBox.Show(
                        "Informe a Data de Solicitação!",
                        "Alerta",
                        MessageBoxButtons.OK);
                }
             
                else
                {
                    if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        _solicitarDto.CodigoSolicitacao = 0;
                        _solicitarDto.idPneu = Convert.ToInt32(txtPNEUCOD_Cadastro_de_SolicitacaoPNEU.SelectedValue.ToString());
                        _solicitarDto.Placa = (txtPLACA_Cadastro_de_SolicitacaoPNEU.SelectedValue.ToString());
                        _solicitarDto.Quantidade = Convert.ToInt32(txtQUANTIDADE_Cadastro_de_SolicitacaoPNEU.Text);
                        _solicitarDto.DatadeSolicitacao = Convert.ToDateTime(txtDATA_Cadastro_de_SolicitacaoPNEU.Text);
                        _solicitarDto.Observacao = Convert.ToString(txtOBS_Cadastro_de_SolicitacaoPNEU.Text);
                    
                        _solicitarBll.Inserir(_solicitarDto);
                       
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

        private DataTable CarregarPneus()
        {
            return Conexao.obterDados("select idpneu, marca " +
                                      "  from tblpneu" +
                                      " ORDER BY marca ASC");
        }

        private void CarregarCombo()
        {
            //_listaCursos = _cursoBll.ObterDados(0, string.Empty);
            txtPLACA_Cadastro_de_SolicitacaoPNEU.DataSource = CarregarPlacas();

            txtPLACA_Cadastro_de_SolicitacaoPNEU.DisplayMember = "placa";
            txtPLACA_Cadastro_de_SolicitacaoPNEU.ValueMember = "placa";

            txtPNEUCOD_Cadastro_de_SolicitacaoPNEU.DataSource = CarregarPneus();

            txtPNEUCOD_Cadastro_de_SolicitacaoPNEU.DisplayMember = "marca";
            txtPNEUCOD_Cadastro_de_SolicitacaoPNEU.ValueMember = "idpneu";
        }

        private void Requisição_de_Manuntenção_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }
    }
}
