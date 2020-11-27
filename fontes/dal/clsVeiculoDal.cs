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
    public class clsVeiculoDal 
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;


        // METÓDO PARA INSERIR VEICULO
        public void Inserir(clsVeiculoDto Veiculo)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblveiculo (placa, anoveiculo, marca, modelo, consumo, tipo, disponibilidade) " +
                "VALUES " +
                "('" + Veiculo.Placa + "'," + Veiculo.Ano + ",'" + Veiculo.Marca + "','" + Veiculo.Modelo + "','" + Veiculo.Consumo + "','" +
                Veiculo.Tipo + "','" + Veiculo.Disponibilidade + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR VEICULO
        public void Alterar(clsVeiculoDto Veiculo)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                "UPDATE tblveiculo " +
                " SET marca = '" + Veiculo.Marca + "', " +
                " anoveiculo = " + Veiculo.Ano + ", " +
                " modelo = '" + Veiculo.Modelo + "', " +
                " consumo = '" + Veiculo.Consumo + "', " +
                " tipo = '" + Veiculo.Tipo + "', " +
                " disponibilidade = '" + Veiculo.Disponibilidade + "' " +
                "WHERE placa = '" + Veiculo.Placa + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }

        }

        // METÓDO PARA EXCLUIR VEICULO
        public void Excluir(String Placa)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblveiculo WHERE placa = '" + Placa + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsVeiculoDto> obterDados(int tipo, String filtro)
        {
            List<clsVeiculoDto> veiculoDtos = new List<clsVeiculoDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select placa, anoveiculo, marca, modelo, consumo, tipo, disponibilidade" +
                                              " from tblveiculo");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select placa, anoveiculo, marca, modelo, consumo, tipo, disponibilidade" +
                                                   " from tblveiculo " +
                                                   " where placa like '%" + filtro + "%'");
                    }

                }
                    _readersql = _comandoSql.ExecuteReader();
                    while (_readersql.Read())
                    {
                        clsVeiculoDto veiculodto = new clsVeiculoDto();

                        veiculodto.Placa = _readersql["placa"].ToString();
                        veiculodto.Ano = Convert.ToInt32(_readersql["anoveiculo"].ToString());
                        veiculodto.Marca = _readersql["marca"].ToString();
                        veiculodto.Modelo = _readersql["modelo"].ToString();
                        veiculodto.Consumo = _readersql["consumo"].ToString();
                        veiculodto.Tipo = _readersql["tipo"].ToString();
                        veiculodto.Disponibilidade = _readersql["disponibilidade"].ToString();
                    
                        veiculoDtos.Add(veiculodto);
                    }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return veiculoDtos;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}