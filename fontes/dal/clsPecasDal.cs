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
    public class clsPecasDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idpeca) + 1), 1) AS proximoNum FROM tblpeca";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR PEÇAS
        public void Inserir(clsPecasDto pecasDto)
        {
            try
            {
                pecasDto.Peca = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblpeca (idpeca, valorpeca, marca, peca, pecaobs) " +
                "VALUES " +
                "(" + pecasDto.Peca + ",'" + pecasDto.Valor + "','" + pecasDto.Marca + "','" + pecasDto.Pecas + "','" + pecasDto.OBS + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR PEÇAS
        public void Alterar(clsPecasDto Pecas)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblmultas " +
                 " SET marca = '" + Pecas.Marca + "', " +
                 " valorpeca = '" + Pecas.Valor + "', " +
                 " peca = '" + Pecas.Pecas + "', " +
                 " pecaobs = '" + Pecas.OBS + "', " +
                 "WHERE idpeca = " + Pecas.Peca;


                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR PEÇA
        public void Excluir(int idpeca)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblpeca WHERE idpeca = " + idpeca;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsPecasDto> obterdados()
        {
            List<clsPecasDto> pecasDts = new List<clsPecasDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idpeca, valorpeca, marca, peca, pecaobs " +
                                              " from tblpeca  ");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsPecasDto pecaDto = new clsPecasDto();


                pecaDto.Peca = Convert.ToInt32(_readersql["idpeca"].ToString());
                pecaDto.Valor = Convert.ToInt32(_readersql["valorpeca"].ToString());
                pecaDto.Marca = (_readersql["marca"].ToString());
                pecaDto.Pecas = (_readersql["peca"].ToString());
                pecaDto.OBS = (_readersql["pecaobs"].ToString());

                pecasDts.Add(pecaDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return pecasDts;
        }

        public List<clsPecasDto> obterDados(int tipo, String filtro)
        {
            List<clsPecasDto> pecasDts = new List<clsPecasDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idpeca, valorpeca, marca, peca, pecaobs " +
                                              " from tblpeca ");
                }
                else if (tipo == 1)
                {
                    _comandoSql.CommandText = ("select idpeca, valorpeca, marca, peca, pecaobs " +
                                              " from tblpeca " +
                                              " where idpeca like '%" + filtro + "%'");
                }


                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsPecasDto pecaDto = new clsPecasDto();

                    pecaDto.Peca = Convert.ToInt32(_readersql["idpeca"].ToString());
                    pecaDto.Valor = Convert.ToDecimal(_readersql["valorpeca"].ToString());
                    pecaDto.Marca = (_readersql["marca"].ToString());
                    pecaDto.Pecas = (_readersql["peca"].ToString());
                    pecaDto.OBS = (_readersql["pecaobs"].ToString());

                    pecasDts.Add(pecaDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return pecasDts;
            }
            catch (Exception)
            {
                return null;
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
                     "select nome from tblmotorista where idmotorista = " + idinfracao;

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
