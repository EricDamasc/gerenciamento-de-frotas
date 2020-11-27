using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using dal;
using dto;

namespace bll
{
    public class clsUsuarioBll
    {
        clsUsuarioDal _usuarioDal;

        public void Inserir(clsUsuarioDto Usuario)
        {
            _usuarioDal = new clsUsuarioDal();
            try
            {
                if (Usuario.CPF.ToUpper() != "" || Usuario.Senha.ToUpper() != "" || Usuario.Email.ToUpper() != "" || Usuario.Perfil.ToUpper() != "")
            
                {    
                    _usuarioDal.Inserir(Usuario);
                }
                else
                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void Alterar(clsUsuarioDto Usuario)
        {
                _usuarioDal = new clsUsuarioDal();
        try
        {
            if (Usuario.CPF.ToUpper() != "" || Usuario.Senha.ToUpper() != "" || Usuario.Email.ToUpper() != "" || Usuario.Perfil.ToUpper() != "")

            {
                _usuarioDal.Alterar(Usuario);
            }
            else
            {
                throw new Exception("PREENCHIMENTO INCORRETO");
            }
        }

        catch (Exception)
        {
            throw;
        }
    }

        public void Excluir(String Cpf)
        {
            _usuarioDal = new clsUsuarioDal();
    
            try
            {
                if (Cpf == "")
                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                }
                else
                {
                    _usuarioDal.Excluir(Cpf); 
                 
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsUsuarioDto> ObterDados(int tipo, String filtro)
        {
            clsUsuarioDal _usuarioDal = new clsUsuarioDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _usuarioDal.obterDados(tipo, filtro);
                }

                else
                {
                    throw new Exception("A informação do Tipo para a consulta não foi fornecedida!");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsUsuarioDto> obterDados(int tipo, String filtro)
        {
             clsUsuarioDal _usuarioDal = new clsUsuarioDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _usuarioDal.obterDados(tipo, filtro);
                }
                else
                {
                    throw new Exception("Não foi possivel realizar a busca");
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
