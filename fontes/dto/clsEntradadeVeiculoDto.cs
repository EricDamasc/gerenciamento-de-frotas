using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsEntradadeVeiculoDto
    {
        private int _saida;
        private DateTime _DataChegada;
    
        public int Saida
        {
            get { return _saida; }
            set { _saida = value; }
        }

        public DateTime DataChegada
        {
            get { return _DataChegada; }
            set { _DataChegada = value; }
        }

    }
}
