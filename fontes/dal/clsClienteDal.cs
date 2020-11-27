using dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class clsClienteDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        // METODO OBTER PROXIMO CODIGO DO CLIENTE
        private Int32 obterProximocodigo()
        {
            Int32 proximoNum;

            _conexao = Conexao.ObterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idcliente) + 1), 1) AS proximoNum FROM tblcliente";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
       
        // METÓDO PARA INSERIR CLIENTE
        public void Inserir(clsClienteDto Cliente)
        {
            try
            {
                Cliente.Cliente = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblcliente (idcliente, telefone, cnpj, empresa, email, cep, estado) " +
                "VALUES " +
                "('" + Cliente.Cliente + "','" + Cliente.Telefone + "','" + Cliente.CNPJ + "','" + Cliente.Empresa + "','" + 
                Cliente.Email + "','" + Cliente.CEP + "','" + Cliente.Estados + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR CLIENTE
        public void Alterar(clsClienteDto Cliente)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                "UPDATE tblcliente " +
                " SET empresa = '" + Cliente.Empresa + "', " +
                " telefone = '" + Cliente.Telefone + "', " +
                " cnpj = '" + Cliente.CNPJ + "', " +
                " email = '" + Cliente.Email + "', " +
                " cep = '" + Cliente.CEP + "', " +
                " estado = '" + Cliente.Estados + "' " +
                "WHERE idcliente = '" + Cliente.Cliente + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }

        }

        // METÓDO PARA EXCLUIR CLIENTE
        public void Excluir(String Cliente)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblcliente WHERE idcliente = '" + Cliente + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsClienteDto> obterDados(int tipo, String filtro)
        {
            List<clsClienteDto> clienteDtos = new List<clsClienteDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idcliente, telefone, cnpj, empresa, email, cep, estado" +
                                              " from tblcliente");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select idcliente, telefone, cnpj, empresa, email, cep, estado" +
                                                   " from tblcliente " +
                                                   " where idcliente like '%" + filtro + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsClienteDto clientedto = new clsClienteDto();

                    clientedto.Cliente = Convert.ToInt32(_readersql["idcliente"].ToString());
                    clientedto.Telefone =_readersql["telefone"].ToString();
                    clientedto.CNPJ = _readersql["cnpj"].ToString();
                    clientedto.Empresa = _readersql["empresa"].ToString();
                    clientedto.Email = _readersql["email"].ToString();
                    clientedto.CEP = _readersql["cep"].ToString();
                    clientedto.Estados = _readersql["estado"].ToString();

                    clienteDtos.Add(clientedto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return clienteDtos;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}