using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsAbastecimentoDto
    {
        private int _abastecimeto;
        private String _combustivel;
        private String _placa;
        private DateTime _dataabastecimento;
        private Decimal _valor;

        public int Abastecimento
        {
            get { return _abastecimeto; }
            set { _abastecimeto = value; }
        }

        public String Combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }
        
        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public DateTime DatadeAbastecimento
        {
            get { return _dataabastecimento; }
            set { _dataabastecimento = value; }
        }

        public Decimal Valor
        { 
            get { return _valor; }
            set { _valor = value; }
        }
    }
}
