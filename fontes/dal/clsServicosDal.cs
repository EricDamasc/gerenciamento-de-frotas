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
    public class clsServicosDal
    {
        public DataTable ObterDados(int tipo, String filtro)
        {            
            try
            {
                if (tipo == 0)
                {
                    return Conexao.obterDados("select idautoinfracao, idmotorista, placa, valor,  vencimento " +
                                               " from tblmultas ");
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
