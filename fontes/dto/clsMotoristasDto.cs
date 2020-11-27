using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsMotoristasDto
    {
        private int _idmotorista;
        private String _rg;
        private String _cpf;
        private String _nome;
        private String _nascimento;
        private String _numcnh;
        private String _tipocnh;
        private String _validacnh;                
        
        public int IdMotorista
        {
            get { return _idmotorista; }
            set { _idmotorista = value; }
        }

        public String RG
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String Nascimento
        {
            get { return _nascimento; }
            set { _nascimento = value; }
        }

        public String NumCNH
        {
            get { return _numcnh; }
            set { _numcnh = value; }
        }

        public String TipoCNH
        {
            get { return _tipocnh; }
            set { _tipocnh = value; }
        }

        public String ValidadeCNH
        {
            get { return _validacnh; }
            set { _validacnh = value; }
        }
    }
}
