using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_FrotadeVeiculos
{
    public partial class FrmTeladeLogin : Form
    {
        public FrmTeladeLogin()
        {
            InitializeComponent();
        }

        private void btnLOGAR_Click(object sender, EventArgs e)
        {
          SqlConnection conexao = new SqlConnection("Data Source=ERIC;" + 
                                            "Initial Catalog=DBFrotas; " +
                                            "Integrated Security=True;" +
                                            "Connect Timeout=30");
   
            try
            {
                if (txtCPFLOGIN.Text == "" || txtSENHALOGIN.Text == "") //Campos vazios
                {
                    if (txtCPFLOGIN.Text == "") //txtuser vazia
                    {
                        MessageBox.Show("Campo CPF vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSENHALOGIN.Text = "";
                        txtSENHALOGIN.Focus();
                    }
                    else if (txtSENHALOGIN.Text == "") //txtPass vazia
                    {
                        MessageBox.Show("Campo SENHA vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSENHALOGIN.Text = "";
                        txtSENHALOGIN.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Por favor verifique os dados de login!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCPFLOGIN.Text = "";
                        txtSENHALOGIN.Text = "";
                    }
                }
                else
                {
                    conexao.Open();
                    String cpf = txtCPFLOGIN.Text;
                    string senha = txtSENHALOGIN.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblusuario WHERE cpf='" + txtCPFLOGIN.Text + "' AND usersenha ='" + txtSENHALOGIN.Text + "'", conexao);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        //Abre Form Geral caso os dados do Login estejam certos
                        Tela_Inicial Tela_inicial = new Tela_Inicial();
                        Tela_inicial.Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifique os dados inseridos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            //*/
            
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            VALIDAR_LOGIN _LOGIN = new VALIDAR_LOGIN();
            _LOGIN.ShowDialog();
        }

        private void FrmTeladeLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
