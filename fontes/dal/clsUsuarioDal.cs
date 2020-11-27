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
    public class clsUsuarioDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        // METÓDO PARA INSERIR USUARIO
        public void Inserir(clsUsuarioDto usuario)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblusuario (cpf, perfil , useremail, usersenha) " +
            "VALUES " +
            "('" + usuario.CPF + "','" + usuario.Perfil + "','" + usuario.Email + "','" + usuario.Senha + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR USUARIO
        public void Alterar(clsUsuarioDto usuario)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
            "UPDATE tblusuario " +
             " SET perfil = '" + usuario.Perfil + "', " +
             " useremail = '" + usuario.Email + "', " +
             " usersenha = '" + usuario.Senha + "', " +
             "WHERE cpf = '" + usuario.CPF + "'";


            _comandoSql.ExecuteNonQuery();
            Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }
      
        // METÓDO PARA EXCLUIR USUARIO
        public void Excluir(String CPF)
        {
        try
        {
            _conexao = Conexao.ObterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = "DELETE FROM tblusuario WHERE cpf = '" + CPF + "'";

            _comandoSql.ExecuteNonQuery();
            Conexao.fecharConexao(_conexao);
        }

        catch (Exception)
        {
            throw;
        }
}

        public List<clsUsuarioDto> obterDados(int tipo, String filtro)
        {
            List<clsUsuarioDto> usuarioDtos = new List<clsUsuarioDto>();
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select cpf, useremail, perfil, usersenha " +
                                                  " from tblusuario ");
                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select cpf, useremail, perfil, usersenha " +
                                                  " from tblusuario " +
                                                  " where perfil like '%" + filtro + "%'");
                    }
                }

                _readersql = _comandoSql.ExecuteReader();

                while (_readersql.Read())
                {
                    clsUsuarioDto usuarioDto = new clsUsuarioDto();

                    usuarioDto.CPF = _readersql["cpf"].ToString();
                    usuarioDto.Senha = _readersql["usersenha"].ToString();
                    usuarioDto.Email = _readersql["useremail"].ToString();
                    usuarioDto.Perfil = _readersql["perfil"].ToString();

                    usuarioDtos.Add(usuarioDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);
                return usuarioDtos;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
