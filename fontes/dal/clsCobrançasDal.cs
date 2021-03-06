﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class clsCobrançasDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;

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

        public DataTable ObterDados(int tipo, String filtro)
        {
            try
            {
                if (tipo == 0)
                {
                    return Conexao.obterDados("select idlocacao, placa, valorlocacao, datalocacao " +
                                               " from tbllocacao ");
                }
                else if (tipo == 1)
                {
                    return Conexao.obterDados("select odsmanutencao, idpeca, placa, problemas, datamanu, tipodemanu " +
                                              " from tblmanutencao ");
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
