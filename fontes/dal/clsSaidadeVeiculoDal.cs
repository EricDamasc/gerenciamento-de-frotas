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
    public class clsSaidadeVeiculoDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idsaida) + 1), 1) AS proximoNum FROM tblsaidaveiculo";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR SAIDA
        public void Inserir(clsSaidadeVeiculoDto saidaDto)
        {
            try
            {
                saidaDto.Saida = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblsaidaveiculo (idsaida, idmotorista, idcliente, datasaida) " +
                "VALUES " +
                "(" + saidaDto.Saida + ",'" + saidaDto.IdMotorista + "','" + saidaDto.Cliente + "','" + saidaDto.DataSaida + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR SAIDA
        public void Alterar(clsSaidadeVeiculoDto saidas)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblsaidaveiculo " +
                 " SET idmotorista = '" + saidas.IdMotorista + "', " +
                 " idcliente = '" + saidas.Cliente + "', " +
                 " datasaida = '" + saidas.DataSaida + "', " +
                 "WHERE idsaida = " + saidas.Saida;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR SAIDA
        public void Excluir(int idsaida)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblsaidaveiculo WHERE idsaida = " + idsaida;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsSaidadeVeiculoDto> obterdadosaida(int tipo, String filtro)
        {
            List<clsSaidadeVeiculoDto> saidaDto = new List<clsSaidadeVeiculoDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idsaida,	idmotorista, idcliente,	datasaida" +
                                       " from tblsaidaveiculo ");

            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsSaidadeVeiculoDto saidadts = new clsSaidadeVeiculoDto();

                saidadts.Saida = Convert.ToInt32(_readersql["idsaida"].ToString());
                saidadts.IdMotorista = Convert.ToInt32(_readersql["idmotorista"].ToString());
                saidadts.Cliente = Convert.ToInt32(_readersql["idcliente"].ToString());
                saidadts.DataSaida = Convert.ToDateTime(_readersql["datasaida"].ToString());
      
                saidaDto.Add(saidadts);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return saidaDto;
        }

        public List<clsSaidadeVeiculoDto> obterDados(int tipo, String filtro)
        {
            List<clsSaidadeVeiculoDto> saidaDto = new List<clsSaidadeVeiculoDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idsaida, idmotorista, idcliente, datasaida" +
                                               "from tblsaidaveiculo ");
                }
                else if (tipo == 1)
                {
                    _comandoSql.CommandText = ("select idsaida, idmotorista, idcliente, datasaida" +
                                               "from tblsaidaveiculo " +
                                               " where datasaida like '%" + filtro + "%'");
                }


                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsSaidadeVeiculoDto saidadts = new clsSaidadeVeiculoDto();

                    saidadts.Saida = Convert.ToInt32(_readersql["idsaida"].ToString());
                    saidadts.IdMotorista = Convert.ToInt32(_readersql["idmotorista"].ToString());
                    saidadts.Cliente = Convert.ToInt32(_readersql["idcliente"].ToString());
                    saidadts.DataSaida = Convert.ToDateTime(_readersql["datasaida"].ToString());

                    saidaDto.Add(saidadts);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return saidaDto;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public string ObterCombo(int codigo)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                    "select idcliente " +
                     "  from tblcliente" +
                     " where idcliente = @idcliente";

                _comandoSql.CommandText =
                     "select edinome " +
                     "  from tblmotorista" +
                     " where idmotorista = @idmotorista";

                _comandoSql.Parameters.Add("@idcliente", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@idmotorista", SqlDbType.Int).Value = codigo;

                string x = _comandoSql.ExecuteScalar().ToString();
                Conexao.fecharConexao(_conexao);
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String obternome(int idinfracao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select idmotorista from tblsaidaveiculo where idsaida = " + idinfracao;

                //_comandoSql.Parameters.Add("@estid", SqlDbType.Int).Value = codigo;

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
