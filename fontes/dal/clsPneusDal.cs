using dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class clsPneusDal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idpneu) + 1), 1) AS proximoNum FROM tblpneu";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR PNEU
        public void Inserir(clsPneusDto pneuDto)
        {
            try
            {
                pneuDto.Pneu = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblpneu (idpneu, marca, tamanho, preco, pneuobs) " +
                "VALUES " +
                "(" + pneuDto.Pneu + ",'" + pneuDto.Marca + "'," + pneuDto.Tamanho + ",'" + pneuDto.Preco + "','" + pneuDto.Observacao + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR PNEU
        public void Alterar(clsPneusDto Pneu)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText = 
                "UPDATE tblpneu " +
                 " SET marca = '" + Pneu.Marca + "', " +
                 " tamanho = '" + Pneu.Tamanho + "', " +
                 " preco = '" + Pneu.Preco + "', " +
                 " pneuobs = '" + Pneu.Observacao + "', " +
                 "WHERE idpneu = " + Pneu.Pneu;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR PNEU
        public void Excluir(int idPneu)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblpneu WHERE idpneu = " + idPneu;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsPneusDto> obterDados(int tipo, String filtro)
        {
            List<clsPneusDto> pneuDto = new List<clsPneusDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idpneu, marca, tamanho, preco, pneuobs" +
                                               " from tblpneu");
                }
                else 
                {
                
                    if (tipo == 1)
                    {
                    _comandoSql.CommandText = ("select idpneu, marca, tamanho, preco, pneuobs" +
                                               "from tblpneu " +
                                               " where idpneu like '%" + filtro + "%'");
                    }
                }

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsPneusDto pneusdts = new clsPneusDto();

                    pneusdts.Pneu = Convert.ToInt32(_readersql["idpneu"].ToString());
                    pneusdts.Preco = Decimal.Parse(_readersql["preco"].ToString());
                    pneusdts.Marca = _readersql["marca"].ToString();
                    pneusdts.Tamanho = Convert.ToInt32(_readersql["tamanho"].ToString());
                    pneusdts.Observacao = Convert.ToString(_readersql["pneuobs"].ToString());

                    pneuDto.Add(pneusdts);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return pneuDto;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
