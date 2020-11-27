using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsSolicitacaoPneuDto
    {
        private int _idSolicitacao;
        private int _idPneu;
        private String _placa;
        private int _quantidade;
        private DateTime _datadeSolicitacao;
        private String _observacao;
        private int _idPneus;
        private int _CodigoPlaca;

        public int CodigoSolicitacao
        {
            get { return _idSolicitacao; }
            set { _idSolicitacao = value; }
        }

        public int idPneu
        {
            get { return _idPneu; }
            set { _idPneu = value; }
        }

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public DateTime DatadeSolicitacao
        {
            get { return _datadeSolicitacao; }
            set { _datadeSolicitacao = value; }
        }

        public String Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public int CodigoPneu
        {
            get { return _idPneus; }
            set { _idPneus = value; }
        }

        public int CodigoPlaca
        {
            get { return _CodigoPlaca; }
            set { _CodigoPlaca = value; }
        }
    }
}
