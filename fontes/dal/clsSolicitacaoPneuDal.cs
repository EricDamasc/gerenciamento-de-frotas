using dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class clsSolicitacaoPneuDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        private Int32 obterProximocodigo()
        {
            Int32 proximoNum;

            _conexao = Conexao.ObterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idsolicitacao) + 1), 1) AS proximoNum FROM tblsolicitacaopneu";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR SOLICITAÇÃO
        public void Inserir(clsSolicitacaoPneuDto solicitacasoDto)
        {
            try
            {
                solicitacasoDto.CodigoSolicitacao = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblsolicitacaopneu (idsolicitacao, idpneu, placa, quantidade, datasolicitacao, observacao) " +
                "VALUES " +
                "(" + solicitacasoDto.CodigoSolicitacao + ",'" + solicitacasoDto.idPneu + "','" + solicitacasoDto.Placa + "','" + solicitacasoDto.Quantidade + "','" + solicitacasoDto.DatadeSolicitacao + "','" + solicitacasoDto.Observacao + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR SOLICITAÇÃO
        public void Alterar(clsSolicitacaoPneuDto Solicitacao)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblsolicitacaopneu " +
                 " SET idpneu = '" + Solicitacao.idPneu + "', " +
                 " placa = '" + Solicitacao.Placa + "', " +
                 " quantidade = '" + Solicitacao.Quantidade + "', " +
                 " DatadeSolicitacao = '" + Solicitacao.DatadeSolicitacao + "', " +
                 " Observacao = '" + Solicitacao.Observacao + "', " +
                 "WHERE idsolicitacao = " + Solicitacao.CodigoSolicitacao;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR SOLICITAÇÃO
        public void Excluir(int idPneu)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblsolicitacaopneu WHERE idsolicitacao = " + idPneu;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsSolicitacaoPneuDto> obterdadosolicitacao()
        {
            List<clsSolicitacaoPneuDto> solicitacaoDto = new List<clsSolicitacaoPneuDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idsolicitacao, idpneu, placa, quantidade, datasolicitacao, observacao" +
                                       "from tblsolicitacaopneu ");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsSolicitacaoPneuDto solicitacaodts = new clsSolicitacaoPneuDto();

                solicitacaodts.CodigoSolicitacao = Convert.ToInt32(_readersql["idsolicitacao"].ToString());
                solicitacaodts.idPneu = Convert.ToInt32(_readersql["idPneu"].ToString());
                solicitacaodts.Placa = Convert.ToString(_readersql["placa"].ToString());
                solicitacaodts.Quantidade = Convert.ToInt32(_readersql["quantidade"].ToString());
                solicitacaodts.DatadeSolicitacao = Convert.ToDateTime(_readersql["datadesolicitacao"].ToString());
                solicitacaodts.Observacao = Convert.ToString(_readersql["observacao"].ToString());
                solicitacaodts.CodigoPneu = Convert.ToInt32(_readersql["idpneu"].ToString());
                solicitacaodts.CodigoPlaca = Convert.ToInt32(_readersql["placa"].ToString());

                solicitacaoDto.Add(solicitacaodts);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return solicitacaoDto;
        }

        public List<clsSolicitacaoPneuDto> obterDados(int tipo, String filtro)
        {
            List<clsSolicitacaoPneuDto> solicitacaoDto = new List<clsSolicitacaoPneuDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idsolicitacao, idpneu, placa, quantidade, datasolicitacao, observacao" +
                                               "from tblsolicitacaopneu ");
                }
                else if (tipo == 1)
                {
                    _comandoSql.CommandText = ("select idsolicitacao, idpneu, placa, quantidade, datasolicitacao, observacao" +
                                                "from tblsolicitacaopneu " +
                                               " where idpneu like '%" + filtro + "%'");
                }


                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsSolicitacaoPneuDto solicitacaodts = new clsSolicitacaoPneuDto();

                    solicitacaodts.CodigoSolicitacao = Convert.ToInt32(_readersql["idsolicitacao"].ToString());
                    solicitacaodts.idPneu = Convert.ToInt32(_readersql["idPneu"].ToString());
                    solicitacaodts.Placa = Convert.ToString(_readersql["placa"].ToString());
                    solicitacaodts.Quantidade = Convert.ToInt32(_readersql["quantidade"].ToString());
                    solicitacaodts.DatadeSolicitacao = Convert.ToDateTime(_readersql["datadesolicitacao"].ToString());
                    solicitacaodts.Observacao = Convert.ToString(_readersql["observacao"].ToString());
                    solicitacaodts.CodigoPneu = Convert.ToInt32(_readersql["idpneu"].ToString());
                    solicitacaodts.CodigoPlaca = Convert.ToInt32(_readersql["placa"].ToString());
                    
                    solicitacaoDto.Add(solicitacaodts);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return solicitacaoDto;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public String obternome(int idSolicitacao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select idsolicitacao from tblsolicitacaopneu where placa = " + idSolicitacao;

                
                String x = _comandoSql.ExecuteScalar().ToString();
                Conexao.fecharConexao(_conexao);
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
