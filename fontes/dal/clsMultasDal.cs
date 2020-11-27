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
    public class clsMultasDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idautoinfracao) + 1), 1) AS proximoNum FROM tblmultas";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR MULTAS
        public void Inserir(clsMultasDto multasDto)
        {
            try
            {
                multasDto.idinfracao = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblmultas (idautoinfracao, placa, idmotorista, vencimento, valor) " +
                "VALUES " +
                "(" + multasDto.idinfracao + ",'" + multasDto.Placa + "','" + multasDto.idmotorista + "','" + multasDto.Vencimento + "','" + multasDto.Valor + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR MULTAS
        public void Alterar(clsMultasDto Multas)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblmultas " +
                 " SET placa = '" + Multas.Placa + "', " +
                 " valor = '" + Multas.Valor + "', " +
                 " vencimento = '" + Multas.Vencimento + "', " +
                 "WHERE idautoinfracao = " + Multas.idinfracao;


                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR MULTAS
        public void Excluir(int idinfracao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblmultas WHERE idautoinfracao = " + idinfracao;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsMultasDto> obterdadosCombo()
        {
            List<clsMultasDto> multasDts = new List<clsMultasDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idautoinfracao, placa, idmotorista, vencimento, valor " +
                                          " from tblmultas ");

            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsMultasDto multasDto = new clsMultasDto();

                       multasDto.idinfracao = Convert.ToInt32(_readersql["idautoinfracao"].ToString());
                    multasDto.Placa = _readersql["placa"].ToString();
                    multasDto.idmotorista = Convert.ToInt32(_readersql["idmotorista"].ToString());
                    multasDto.Vencimento =Convert.ToDateTime(_readersql["vencimento"].ToString());
                    multasDto.Valor = Convert.ToInt32(_readersql["valor"].ToString());

                multasDts.Add(multasDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return multasDts;
        }

        public List<clsMultasDto> obterDados(int tipo, String filtro)
        {
            List<clsMultasDto> multasDts = new List<clsMultasDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idautoinfracao, idmotorista, placa, valor,  vencimento " +
                                               " from tblmultas ");
                }
                else if(tipo == 1)
                {
                    _comandoSql.CommandText = ("select idautoinfracao, idmotorista, placa, valor,  vencimento " +
                                               " from tblmultas " +
                                              " where placa like '%" + filtro + "%'");
                }
                

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsMultasDto multasDto = new clsMultasDto();

                    multasDto.idinfracao = Convert.ToInt32(_readersql["idautoinfracao"].ToString());
                    multasDto.Placa = _readersql["placa"].ToString();
                    multasDto.idmotorista = Convert.ToInt32(_readersql["idmotorista"].ToString());
                    multasDto.Vencimento =Convert.ToDateTime(_readersql["vencimento"].ToString());
                    multasDto.Valor = Convert.ToDecimal(_readersql["valor"].ToString());
                  
                    multasDts.Add(multasDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return multasDts;
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
                     "select edinome " +
                     "  from tblmotorista" +
                     " where idmotorista = @idmotorista";

                _comandoSql.CommandText =
                    "select placa " +
                     "  from tblveiculo" +
                     " where placa = @placa";

                _comandoSql.Parameters.Add("@idmotorista", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@placa", SqlDbType.Int).Value = codigo;

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
                     "select nome from tblmotorista where idmotorista = " + idinfracao ;

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
