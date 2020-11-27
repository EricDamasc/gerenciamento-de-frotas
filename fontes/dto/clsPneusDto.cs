using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsPneusDto
    {

        private int _idpneu;
        private String _marca;
        private int _tamanho;
        private Decimal _preco;
        private String _pneusobs;

        public int Pneu
        {
            get { return _idpneu; }
            set { _idpneu = value; }
        }

        public String Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public int Tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }

        public Decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        
        public String Observacao
        {
            get { return _pneusobs; }
            set { _pneusobs = value; }
        }
    }
}
