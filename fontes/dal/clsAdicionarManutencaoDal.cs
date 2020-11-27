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
    public class clsAdicionarManutencaoDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(odsmanutencao) + 1), 1) AS proximoNum FROM tblmanutencao";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR MANUTENÇÃO
        public void Inserir(clsAdicionarManutencaoDto manutencaoDto)
        {
            try
            {
                manutencaoDto.ODS = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblmanutencao (odsmanutencao, idpeca, placa, problemas, datamanu, tipodemanu) " +
                "VALUES " +
                "(" + manutencaoDto.ODS + "," + manutencaoDto.idPeca + ",'" + manutencaoDto.Placa + "','" + manutencaoDto.Problemas + "','" + manutencaoDto.DatadeManu + "','" + manutencaoDto.TipoManutencao + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR MANUTENÇÃO
        public void Alterar(clsAdicionarManutencaoDto Manutencao)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblmanutencao " +
                 " SET idpeca = " + Manutencao.idPeca + ", " +
                 " placa = '" + Manutencao.Placa + "', " +
                 " problemas = '" + Manutencao.Problemas + "', " +
                 " datamanu = " + Manutencao.DatadeManu + ", " +
                 " tipodemanu = " + Manutencao.TipoManutencao + ", " +
                 "WHERE odsmanutencao = " + Manutencao.ODS;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR MANUTENÇÃO
        public void Excluir(int odsmanutencao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblmanutencao WHERE odsmanutencao = " + odsmanutencao;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsAdicionarManutencaoDto> obterdadosCombo()
        {
            List<clsAdicionarManutencaoDto> manuntencaoDts = new List<clsAdicionarManutencaoDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select odsmanutencao, idpeca, placa, problemas, datamanu, tipodemanu " +
                                              " from tblmanutencao ");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsAdicionarManutencaoDto manutencaoDto = new clsAdicionarManutencaoDto();


                manutencaoDto.ODS = Convert.ToInt32(_readersql["odsmanutencao"].ToString());
                manutencaoDto.idPeca = Convert.ToInt32(_readersql["idpeca"].ToString());
                manutencaoDto.Placa = (_readersql["placa"].ToString());
                manutencaoDto.Problemas = (_readersql["problemas"].ToString());
                manutencaoDto.DatadeManu = Convert.ToDateTime(_readersql["datamanu"].ToString());
                manutencaoDto.TipoManutencao = (_readersql["tipodemanu"].ToString());

                manuntencaoDts.Add(manutencaoDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return manuntencaoDts;
        }

        public List<clsAdicionarManutencaoDto> obterDados(int tipo, String filtro)
        {
            List<clsAdicionarManutencaoDto> manuntencaoDts = new List<clsAdicionarManutencaoDto>();


            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select odsmanutencao, idpeca, placa, problemas, datamanu, tipodemanu " +
                                              " from tblmanutencao ");
                }
                else if (tipo == 1)
                {
                    _comandoSql.CommandText = ("select odsmanutencao, idpeca, placa, problemas, datamanu, tipodemanu " +
                                              " from tblmanutencao " +
                                              " where odsmanutencao like '%" + filtro + "%'");
                }


                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsAdicionarManutencaoDto manutencaoDto = new clsAdicionarManutencaoDto();


                    manutencaoDto.ODS = Convert.ToInt32(_readersql["odsmanutencao"].ToString());
                    manutencaoDto.idPeca = Convert.ToInt32(_readersql["idpeca"].ToString());
                    manutencaoDto.Placa = (_readersql["placa"].ToString());
                    manutencaoDto.Problemas = (_readersql["problemas"].ToString());
                    manutencaoDto.DatadeManu = Convert.ToDateTime(_readersql["datamanu"].ToString());
                    manutencaoDto.TipoManutencao = (_readersql["tipodemanu"].ToString());

                    manuntencaoDts.Add(manutencaoDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return manuntencaoDts;
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
                     "select idpeca " +
                     "  from tblpeca" +
                     " where idpeca = @idpeca";

                _comandoSql.CommandText =
                    "select placa " +
                     "  from tblveiculo" +
                     " where placa = @placa";

                _comandoSql.Parameters.Add("@idpeca", SqlDbType.Int).Value = codigo;
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

        public String obternome(int odsmanutencao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select nome from tblmanutencao where odsmanutencao = " + odsmanutencao;

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
