using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsUsuarioDto
    {
        private String _perfil;
        private String _senha;
        private String _cpf;
        private String _email;

        public String Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public String Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }


    }
}
