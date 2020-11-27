using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsClienteDto
    {
        private int _idcliente;
        private String _telefone;
        private String _cnpj;
        private String _empresa;
        private String _email;
        private String _cep;
        private String _estados;

        public int Cliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }

        public String Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public String Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public String CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public String Estados
        {
            get { return _estados; }
            set { _estados = value; }
        }

    }
}
