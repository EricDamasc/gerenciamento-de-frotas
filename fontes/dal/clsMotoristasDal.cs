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
    public class clsMotoristasDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        // METODO OBTER PROXIMO CODIGO DO MOTORISTA
        private Int32 obterProximocodigo()
        {
            Int32 proximoNum;

            _conexao = Conexao.ObterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idmotorista) + 1), 1) AS proximoNum FROM tblmotorista";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }
        // METÓDO PARA INSERIR USUARIO
        public void Inserir(clsMotoristasDto Motorista)
        {
            //Motorista.IdMotorista = Conexao.GerarNovocodigoMotorista();
            try
            {
                Motorista.IdMotorista = obterProximocodigo();
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblmotorista (idmotorista, rg, cpf, nome, nascimento, numcnh, tipocnh, validacnh) " +
                "VALUES " +  
                "(" + Motorista.IdMotorista + ",'" + Motorista.RG + "','" + Motorista.CPF + "','" + Motorista.Nome + "','" + Motorista.Nascimento + "','" + Motorista.NumCNH + "','" + Motorista.TipoCNH + "','" + Motorista.ValidadeCNH +"')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
        // METÓDO PARA ALTERAR USUARIO
        public void Alterar(clsMotoristasDto Motorista)
        {
            try
            {

                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                "UPDATE tblmotorista " +
                 " SET cpf = '" + Motorista.CPF + "', " +
                 " rg = '" + Motorista.RG + "', " +
                 " nome = '" + Motorista.Nome + "', " +
                 " nascimento = '" + Motorista.Nascimento + "', " +
                 " numcnh = '" + Motorista.NumCNH + "', " +
                 " tipocnh = '" + Motorista.TipoCNH + "', " +
                 " validacnh = '" + Motorista.ValidadeCNH + "' " +
                 "WHERE idmotorista = " + Motorista.IdMotorista;


                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
}
        // METÓDO PARA EXCLUIR USUARIO
        public void Excluir(int Motorista)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblmotorista WHERE idmotorista = " + Motorista;

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }
            catch(Exception)
            {
                throw;
            }

        }

        public List<clsMotoristasDto> obterDados(int tipo, String filtro)
        {
            List<clsMotoristasDto> motoristasDtos = new List<clsMotoristasDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idmotorista, rg, cpf, nome," +
                                              " nascimento, numcnh, tipocnh, validacnh, idmotorista " +
                                              " from tblmotorista ");
                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select idmotorista, rg, cpf, nome, " +
                                                  " nascimento, numcnh, tipocnh, validacnh, idmotorista " +
                                                  " from tblmotorista " +
                                                  " where cpf like '%" + filtro + "%'");
                    }

                }

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsMotoristasDto motoristasDto = new clsMotoristasDto();

                    motoristasDto.IdMotorista = Convert.ToInt32(_readersql["idmotorista"].ToString());
                    motoristasDto.RG = _readersql["rg"].ToString();
                    motoristasDto.CPF = _readersql["cpf"].ToString();
                    motoristasDto.Nome = _readersql["nome"].ToString();
                    motoristasDto.Nascimento = _readersql["nascimento"].ToString();
                    motoristasDto.NumCNH = _readersql["numcnh"].ToString();
                    motoristasDto.TipoCNH = _readersql["tipocnh"].ToString();
                    motoristasDto.ValidadeCNH = _readersql["validacnh"].ToString();

                    motoristasDtos.Add(motoristasDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return motoristasDtos;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
