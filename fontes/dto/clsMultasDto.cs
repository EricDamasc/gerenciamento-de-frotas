using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsMultasDto
    {
        private int _idinfracao;
        private String _placa;
        private int _idmotorista;
        private DateTime _vencimento;
        private decimal _valor;

        public int idinfracao
        {
            get { return _idinfracao; }
            set { _idinfracao = value; }
        }

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public int idmotorista
        {
            get { return _idmotorista; }
            set { _idmotorista = value; }
        }

        public DateTime Vencimento
        {
            get { return _vencimento; }
            set { _vencimento = value; }
        }

        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

    }
}
