using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsPecasDto
    {
        private int _idpeca;
        private decimal _valorpeca;
        private String _marca;
        private String _peca;
        private String _pecaobs;

        public int Peca
        {
            get { return _idpeca; }
            set { _idpeca = value; }
        }

        public decimal Valor
        {
            get { return _valorpeca; }
            set { _valorpeca = value; }
        }

        public String Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public String Pecas
        {
            get { return _peca; }
            set { _peca = value; }
        }

        public String OBS
        {
            get { return _pecaobs; }
            set { _pecaobs = value; }
        }

    }
}
