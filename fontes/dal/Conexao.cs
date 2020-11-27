using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace dal
{
    public class Conexao
    {
        private static String _stringConexao = "Data Source=ERIC; " +
                                             "Initial Catalog=DBFrotas; " +
                                             "Integrated Security=true; ";
        private static SqlConnection _conexao;
        private static SqlCommand _comandoSql;
        private static SqlDataAdapter _adaptadorSql;
        private static DataTable _tabela;

        public static SqlConnection ObterConexao()
        {
            try
            {
                _conexao = new SqlConnection(_stringConexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static void fecharConexao(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable obterDados(String sql)
        {
            _conexao = new SqlConnection(_stringConexao);
            _conexao.Open();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = sql;

            _tabela = new DataTable();

            _adaptadorSql = new SqlDataAdapter(_comandoSql);
            _adaptadorSql.Fill(_tabela);

            _conexao.Close();

            return _tabela;
        }
    }
}
