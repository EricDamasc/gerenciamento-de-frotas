using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsSaidadeVeiculoDto
    {
        private int _saida;
        private int _idMotorista;
        private int _cliente;
        private DateTime _DataSaida;
        //private DateTime _DataChegada;
        //private String _veiculoOBS;

        public int Saida
        {
            get { return _saida; }
            set { _saida = value; }
        }

        public int IdMotorista
        {
            get { return _idMotorista; }
            set { _idMotorista = value; }
        }

        public int Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public DateTime DataSaida
        {
            get { return _DataSaida; }
            set { _DataSaida = value; }
        }
    }
}
