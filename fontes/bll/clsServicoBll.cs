using dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsServicoBll
    {
        clsServicosDal servicosDal = new clsServicosDal();

        public DataTable Obterdados(int tipo, String filtro)
        {
            return servicosDal.ObterDados(tipo, filtro);
        }
    }
}
