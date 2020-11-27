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
    public partial class VALIDAR_LOGIN : Form
    {
        public VALIDAR_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_AcessarNovoCadastro_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=ERIC;" +
                                          "Initial Catalog=DBFrotas; " +
                                          "Integrated Security=True;");
            // VALIDA SENHA MASTER PARA CRIAR UM NOVO USUÁRIO
            try
            {
                conexao.Open();
                string senha = txtSENHALOGIN.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblsenhamaster WHERE senhaid ='" + txtSENHALOGIN.Text + "'", conexao);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    //ABRE UM NOVO CADASTRO
                    Console.Beep();
                    Cadastro_de_Usuário cadastro_De_Usuário = new Cadastro_de_Usuário();
                    MessageBox.Show("SENHA ACEITA, EFETUE SEU CADASTRO!", "ACEITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cadastro_De_Usuário.ShowDialog();

                }
                else if (txtSENHALOGIN.Text == "") //txtPass vazia
                {
                    MessageBox.Show("Campo Senha vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSENHALOGIN.Text = "";
                    txtSENHALOGIN.Focus();
                }
                else
                {
                    MessageBox.Show("SENHA INCORRETA, POR FAVOR INSIRA A SENHA CORRETAMENTE!", "REJEITADO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
          

        }

        private void VALIDAR_LOGIN_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("POR FAVOR INSIRA APENAS COM A PRESENÇA DO GERENTE!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
