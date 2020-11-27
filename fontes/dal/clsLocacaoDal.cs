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
     public class clsLocacaoDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idlocacao) + 1), 1) AS proximoNum FROM tbllocacao";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR MULTAS
        public void Inserir(clsLocacaoDto locacaoDto)
        {
            try
            {
                locacaoDto.IdLocacao = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tbllocacao (idlocacao, placa, valorlocacao, datalocacao) " +
                "VALUES " +
                "(" + locacaoDto.IdLocacao + ",'" + locacaoDto.Placa + "'," + locacaoDto.Valorlocacao + ",'" + locacaoDto.DatadeLocacao + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR LOCAÇÃO
        public void Alterar(clsLocacaoDto Locacao)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tbllocacao " +
                 " SET placa = '" + Locacao.Placa + "', " +
                 " valorlocacao = '" + Locacao.Valorlocacao + "', " +
                 " datalocacao = '" + Locacao.DatadeLocacao + "', " +
                 "WHERE idlocacao = " + Locacao.IdLocacao;


                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR LOCAÇÃO
        public void Excluir(int idlocacao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tbllocacao WHERE idlocacao = " + idlocacao;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsLocacaoDto> obterdadosCombo()
        {
            List<clsLocacaoDto> locacaoDts = new List<clsLocacaoDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idlocacao, placa, valorlocacao, datalocacao" +
                                          " from tbllocacao ");





            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsLocacaoDto locacaoDto = new clsLocacaoDto();

                locacaoDto.IdLocacao = Convert.ToInt32(_readersql["idlocacao"].ToString());
                locacaoDto.Placa = _readersql["placa"].ToString();
                locacaoDto.Valorlocacao = Convert.ToInt32(_readersql["valorlocacao"].ToString());
                locacaoDto.DatadeLocacao = Convert.ToDateTime(_readersql["datalocacao"].ToString());

                locacaoDts.Add(locacaoDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return locacaoDts;
        }

        public List<clsLocacaoDto> obterDados(int tipo, String filtro)
        {
            List<clsLocacaoDto> locacaoDts = new List<clsLocacaoDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idlocacao, placa, valorlocacao, datalocacao" +
                                               " from tbllocacao ");
                }
                else if (tipo == 1)
                {
                    _comandoSql.CommandText = ("select idlocacao, placa, valorlocacao, datalocacao" +
                                                " from tbllocacao "+
                                              " where placa like '%" + filtro + "%'");
                }


                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsLocacaoDto locacaoDto = new clsLocacaoDto();

                    locacaoDto.IdLocacao = Convert.ToInt32(_readersql["idlocacao"].ToString());
                    locacaoDto.Placa = _readersql["placa"].ToString();
                    locacaoDto.Valorlocacao = Convert.ToInt32(_readersql["valorlocacao"].ToString());
                    locacaoDto.DatadeLocacao = Convert.ToDateTime(_readersql["datalocacao"].ToString());

                    locacaoDts.Add(locacaoDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return locacaoDts;
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
                     "select placa " +
                     "  from tblveiculo" +
                     " where placa = @placa";

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

        public String obternome(int idlocacao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select placa from tbllocacao where idlocacao = " + idlocacao;

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
