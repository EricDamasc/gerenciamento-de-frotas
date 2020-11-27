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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void btn_CAT_USUARIO_CADASTRAR_Click(object sender, EventArgs e)
        {

            try
            {
                Cadastro_de_Usuário cadastro_De_Usuário = new Cadastro_de_Usuário();
                cadastro_De_Usuário.ShowDialog();
                
            }
            catch
            {
                throw;
            }
        }

        private void btn_CAT_ADD_Manutencao_Click(object sender, EventArgs e)
        {
            Adcionar_Manutenção adcionar_Manutenção = new Adcionar_Manutenção();
            adcionar_Manutenção.ShowDialog();
        }

        private void btn_CAT_ADD_Cliente_Click(object sender, EventArgs e)
        {
            Cliente_ cliente = new Cliente_();
            cliente.ShowDialog();
        }

        private void btn_CAT_RELATORIO_Abastecimento_Click(object sender, EventArgs e)
        {
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.ShowDialog();
        }

        private void btn_CAT_RELATORIO_Finanças_Multas_Click(object sender, EventArgs e)
        {
            Multas multas = new Multas();
            multas.ShowDialog();
        }

        private void btn_CAT_RELATORIO_Requisição_Manutenção_Click(object sender, EventArgs e)
        {
            Requisição_de_Manuntenção requisição = new Requisição_de_Manuntenção();
            requisição.ShowDialog();
        }

        private void btn_CAT_EXIBIR_Motorista_Click(object sender, EventArgs e)
        {
            Exibir_Motoristas exibir_Motoristas = new Exibir_Motoristas();
            exibir_Motoristas.ShowDialog();
        }

        private void btn_CAT_EXCLUIR_Motorista_Click(object sender, EventArgs e)
        {
            Excluir_Motoristas excluir_Motoristas = new Excluir_Motoristas();
            excluir_Motoristas.ShowDialog();
        }

        private void btn_CAT_EXCLUIR_Cliente_Click(object sender, EventArgs e)
        {
            Excluir_Cliente excluir_Cliente = new Excluir_Cliente();
            excluir_Cliente.ShowDialog();
        }

        private void btn_CAT_EXIBIR_Cliente_Click(object sender, EventArgs e)
        {
            Exibir_Cliente exibir_Cliente = new Exibir_Cliente();
            exibir_Cliente.ShowDialog();
        }

        private void btn_CAT_USUARIO_EXCLUIR_Click(object sender, EventArgs e)
        {
            Excluir_Usuário excluir_Usuário = new Excluir_Usuário();
            excluir_Usuário.ShowDialog();
        }

        private void btn_CAT_USUARIO_EXIBIR_Click(object sender, EventArgs e)
        {
            Exibir_Usuário exibir_Usuário = new Exibir_Usuário();
            exibir_Usuário.ShowDialog();
        }

        private void btn_CAT_Manutencao_Prevista_Click(object sender, EventArgs e)
        {
            Manutençao_Prevista manutençao_Prevista = new Manutençao_Prevista();
            manutençao_Prevista.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SAIR DO SISTEMA?", "ALERTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                MessageBox.Show("VOCÊ PERMANECEU NO SISTEMA", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("SAINDO DO SISTEMA", "SAIR");
                Application.Exit();
            }
        }

        private void btn_CAT_ADD_Multas_Click(object sender, EventArgs e)
        {
            Multas multas = new Multas();
            multas.ShowDialog();
        }

        private void btn_CAT_ADD_MotoristaProprio_Click(object sender, EventArgs e)
        {
            Motorista_Próprio motorista_Proprio = new Motorista_Próprio();
            motorista_Proprio.Show();
        }

        private void btn_CAT_ADD_Pneu_Click(object sender, EventArgs e)
        {
            Requisição_de_Manuntenção requisição_De_Manuntenção = new Requisição_de_Manuntenção();
            requisição_De_Manuntenção.ShowDialog();
        }

        private void btn_CAT_RELATORIO_Veiculo_Click(object sender, EventArgs e)
        {
            ExibirVeiculo veiculo = new ExibirVeiculo();
            veiculo.ShowDialog();
        }

        private void btn_CAT_ADD_Abastecimento_Click(object sender, EventArgs e)
        {
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.ShowDialog();
        }

        private void btn_CAT_Financeiro_Servicos_Click(object sender, EventArgs e)
        {
            Servicos servicos = new Servicos();
            servicos.ShowDialog();
        }

        private void btn_CAT_Financeiro_Cobrancas_Click(object sender, EventArgs e)
        {
            Cobrancas cobrancas = new Cobrancas();
            cobrancas.ShowDialog();
        }

        private void btn_CAT_Financeiro_Pagamentos_Click(object sender, EventArgs e)
        {
            Pagamentos pagamentos = new Pagamentos();
            pagamentos.ShowDialog();
        }

        private void btn_CAT_ADD_FROTAS_Click_1(object sender, EventArgs e)
        {
            Adicionar_Veiculo_Próprio adicionar_Veiculo_Próprio = new Adicionar_Veiculo_Próprio();
            adicionar_Veiculo_Próprio.Show();
        }

        private void btn_CAT_FROTAS_ALUGUEL_Click(object sender, EventArgs e)
        {
            Locação locação = new Locação();
            locação.ShowDialog();
        }

        private void btn_CAT_EXIBIR_FROTAS_Click(object sender, EventArgs e)
        {
            ExibirVeiculo veiculo = new ExibirVeiculo();
            veiculo.ShowDialog();
        }

        private void btn_CAT_ALTERAR_FROTAS_Click(object sender, EventArgs e)
        {
            Alterar_Veiculo alterar_Veiculo = new Alterar_Veiculo();
            alterar_Veiculo.ShowDialog();
        }

        private void btn_CAT_PEÇAS_Click(object sender, EventArgs e)
        {
            Peças peças = new Peças();
            peças.ShowDialog();
        }

        private void btn_CAT_PNEUS_Click(object sender, EventArgs e)
        {
            Pneus pneus = new Pneus();
            pneus.ShowDialog();
        }

        private void btn_CAT_EXCLUIR_VEICULO_Click(object sender, EventArgs e)
        {
            Excluir_Veiculo excluir_Veiculo = new Excluir_Veiculo();
            excluir_Veiculo.ShowDialog();
        }

        private void btn_CAT_Alterar_Motorista_Click(object sender, EventArgs e)
        {
            Alterar_Motorista alterar_Motorista = new Alterar_Motorista();
            alterar_Motorista.ShowDialog();
        }

        private void btn_CAT_ALTERAR_Cliente_Click(object sender, EventArgs e)
        {
            Alterar_Cliente alterar_Cliente = new Alterar_Cliente();
            alterar_Cliente.ShowDialog();
        }

        private void btn_CAT_FROTAS_Entradas_Click(object sender, EventArgs e)
        {
            Entrada_de_Veiculo entrada_De_Veiculo = new Entrada_de_Veiculo();
            entrada_De_Veiculo.ShowDialog();
        }

        private void btn_CAT_FROTAS_Saidas_Click(object sender, EventArgs e)
        {
            Entradas_de_Veiculos saida_de_veiculo = new Entradas_de_Veiculos();
            saida_de_veiculo.ShowDialog();
        }

        private void btn_CAT_FROTAS_ALERTAS_Click(object sender, EventArgs e)
        {
            Alertas alertas = new Alertas();
            alertas.ShowDialog();
        }

        private void btn_SOBRE_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }
    }
}
