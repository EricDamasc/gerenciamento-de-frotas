using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto;
using System.Data.Sql;

namespace dal
{
    public class clsAbastecimentoDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idabastecimeto) + 1), 1) AS proximoNum FROM tblabastecimento";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }

        // METÓDO PARA INSERIR VEICULO
        public void Inserir(clsAbastecimentoDto Abastecimento)
        {
            try
            {
                Abastecimento.Abastecimento = obterProximocodigo();
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblabastecimento (idabastecimeto, combustivel, placa, dataabastecimento, valor) " +
                "VALUES " +
                "(" + Abastecimento.Abastecimento + ",'" + Abastecimento.Combustivel + "','" + Abastecimento.Placa + "','" + Abastecimento.DatadeAbastecimento + "','" + Abastecimento.Valor + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR VEICULO
        public void Alterar(clsAbastecimentoDto Abastecimento)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
            
                _comandoSql.CommandText =
                "UPDATE tblabastecimento " +
                " SET combustivel = '" + Abastecimento.Combustivel + "', " +
                " placa = '" + Abastecimento.Placa + "', " +
                " dataabastecimento = '" + Abastecimento.DatadeAbastecimento + "', " +
                " valor = '" + Abastecimento.Valor + "', " +
                "WHERE idabastecimeto = " + Abastecimento.Abastecimento + "";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }

        }

        // METÓDO PARA EXCLUIR VEICULO
        public void Excluir(int idAbastecimento)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblabastecimento WHERE idabastecimeto = '" + idAbastecimento + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsAbastecimentoDto> obterdadosCombo()
        {
            List<clsAbastecimentoDto> abastecimentoDtos = new List<clsAbastecimentoDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idabastecimeto, combustivel, placa, dataabastecimento, valor" +
                                              " from tblabastecimento");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsAbastecimentoDto abastecimentoDto = new clsAbastecimentoDto();

                abastecimentoDto.Abastecimento = Convert.ToInt32(_readersql["idabastecimeto"].ToString());
                abastecimentoDto.Combustivel = (_readersql["combustivel"].ToString());
                abastecimentoDto.Placa = _readersql["placa"].ToString();
                abastecimentoDto.DatadeAbastecimento = Convert.ToDateTime(_readersql["dataabastecimento"].ToString());
                abastecimentoDto.Valor = Convert.ToDecimal(_readersql["valor"].ToString());

                abastecimentoDtos.Add(abastecimentoDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return abastecimentoDtos;
        }

        public List<clsAbastecimentoDto> obterDados(int tipo, String filtro)
        {
            List<clsAbastecimentoDto> abastecimentoDtos = new List<clsAbastecimentoDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idabastecimeto, combustivel, placa, dataabastecimento, valor" +
                                              " from tblabastecimento");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select idabastecimeto, combustivel, placa, dataabastecimento, valor" +
                                                   " from tblabastecimento " +
                                                   " where idabastecimeto like '%" + filtro + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsAbastecimentoDto abastecimentoDto = new clsAbastecimentoDto();

                    abastecimentoDto.Abastecimento = Convert.ToInt32(_readersql["idabastecimeto"].ToString());
                    abastecimentoDto.Combustivel = (_readersql["combustivel"].ToString());
                    abastecimentoDto.Placa = _readersql["placa"].ToString();
                    abastecimentoDto.DatadeAbastecimento = Convert.ToDateTime(_readersql["dataabastecimento"].ToString());
                    abastecimentoDto.Valor = Convert.ToDecimal(_readersql["valor"].ToString());

                    abastecimentoDtos.Add(abastecimentoDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return abastecimentoDtos;

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

        public String obternome(int idabastecimeto)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select nome from tblabastecimento where idabastecimeto = " + idabastecimeto;

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
