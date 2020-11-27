using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsAdicionarManutencaoDto
    {

        private int _odsmanutencao;
        private int _idpeca;
        private String _placa;
        private String _problemas;
        private DateTime _datamanu;
        private String _idtipomanutencao;
   
        public int ODS
        {
            get { return _odsmanutencao; }
            set { _odsmanutencao = value; }
        }

        public int idPeca
        {
            get { return _idpeca; }
            set { _idpeca = value; }
        }

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public String Problemas
        {
            get { return _problemas; }
            set { _problemas = value; }
        }

        public DateTime DatadeManu
        {
            get { return _datamanu; }
            set { _datamanu = value; }
        }

        public String TipoManutencao
        {
            get { return _idtipomanutencao; }
            set { _idtipomanutencao = value; }
        }
    }
}
