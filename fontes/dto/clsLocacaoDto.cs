using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsLocacaoDto
    {
        private int _idlocacao;
        private String _placa;
        private decimal _valorlocacao;
        private DateTime datalocacao;

        public int IdLocacao
        {
            get { return _idlocacao; }
            set { _idlocacao = value; }
        }

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

         public decimal Valorlocacao
        {
            get { return _valorlocacao; }
            set { _valorlocacao = value; }
        }

        public DateTime DatadeLocacao
        {
            get { return datalocacao; }
            set { datalocacao = value; }
        }
    }
}
