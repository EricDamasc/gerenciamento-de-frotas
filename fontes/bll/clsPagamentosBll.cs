using dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsPagamentosBll
    {
        clsPagamentosDal pagamentosDal = new clsPagamentosDal();

        public DataTable Obterdados(int tipo, String filtro)
        {
            return pagamentosDal.ObterDados(tipo, filtro);
        }

        public void ExcluirPneu(int idPneu)
        {
            try
            {

                if (idPneu > 0)
                {
                    pagamentosDal.ExcluirPneu(idPneu);
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

        public void ExcluirPeca(int idPeca)
        {
            try
            {

                if (idPeca > 0)
                {
                    pagamentosDal.ExcluirPeca(idPeca);
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
