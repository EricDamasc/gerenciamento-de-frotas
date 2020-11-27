using dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsCobrançasBll
    {
        clsCobrançasDal cobrancasDal = new clsCobrançasDal();

        public DataTable Obterdados(int tipo, String filtro)
        {
            return cobrancasDal.ObterDados(tipo, filtro);
        }

        public void Excluir(int idlocacao)
        {
            try
            {

                if (idlocacao > 0)
                {
                    cobrancasDal.Excluir(idlocacao);
                }
                else
                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }
    }
}
