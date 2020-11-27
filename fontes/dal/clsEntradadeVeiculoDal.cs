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
    public class clsEntradadeVeiculoDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

 
        // METÓDO PARA INSERIR SAIDA
        public void Inserir(clsEntradadeVeiculoDto entradaDto)
        {
            try
            {
                 _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblentradaveiculo (idsaida, dataentrada) " +
                "VALUES " +
                "(" + entradaDto.Saida + ",'" + entradaDto.DataChegada + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR ENTRADA
        public void Alterar(clsEntradadeVeiculoDto entradas)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblsaidaveiculo " +
                 " SET datachegada = '" + entradas.DataChegada + "', " +
                 "WHERE idsaida = " + entradas.Saida;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA EXCLUIR ENTRADA
        public void Excluir(int identrada)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblsaidaveiculo WHERE idsaida = " + identrada;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<clsEntradadeVeiculoDto> obterdadosaida()
        {
            List<clsEntradadeVeiculoDto> entradaDto = new List<clsEntradadeVeiculoDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select idsaida,	idmotorista, idcliente,	datasaida " +
                                       "from tblsaidaveiculo ");





            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsEntradadeVeiculoDto entradadts = new clsEntradadeVeiculoDto();

                entradadts.Saida = Convert.ToInt32(_readersql["idsaida"].ToString());
                //entradadts.DataChegada = Convert.ToDateTime(_readersql["datachegada"].ToString());

                entradaDto.Add(entradadts);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return entradaDto;
        }

        public List<clsEntradadeVeiculoDto> obterDados(int tipo, String filtro)
        {
            List<clsEntradadeVeiculoDto> entradaDto = new List<clsEntradadeVeiculoDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idsaida,	idmotorista, idcliente,	datasaida " +
                                               "from tblsaidaveiculo ");
                }
                //else if (tipo == 1)
                //{
                //    _comandoSql.CommandText = ("select idsaida,	idmotorista, idcliente,	datasaida, datachegada" +
                //                               "from tblsaidaveiculo " +
                //                               " where datasaida like '%" + filtro + "%'");
                //}


                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsEntradadeVeiculoDto entradadts = new clsEntradadeVeiculoDto();

                    entradadts.Saida = Convert.ToInt32(_readersql["idsaida"].ToString());
                    //entradadts.DataChegada = Convert.ToDateTime(_readersql["datachegada"].ToString());

                    entradaDto.Add(entradadts);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return entradaDto;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public String obternome(int identrada)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select idmotorista from tblsaidaveiculo where idsaida = " + identrada;

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

        public DataTable ObterDadosGRID(int tipo, String filtro)
        {
            try
            {
                if (tipo == 0)
                {
                    return Conexao.obterDados("select idsaida, dataentrada " +
                                               " from tblentradaveiculo ");
                }               
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public DataTable ObterDadosNOVO(int tipo, String filtro)
        {
            try
            {
                if (tipo == 0)
                {
                    return Conexao.obterDados(" select idsaida, idmotorista, idcliente, datasaida " +
                                               "from tblsaidaveiculo ");
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
