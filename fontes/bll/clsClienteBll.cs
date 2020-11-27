using dal;
using dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsClienteBll
    {
        clsClienteDal _clienteDal;

        public void Inserir(clsClienteDto Cliente)
        {
             _clienteDal = new clsClienteDal();
            
            try
            {
                if (Cliente.Cliente.ToString() != "" || Cliente.Telefone.ToUpper() != "" || Cliente.Empresa.ToUpper() != "" || Cliente.CNPJ.ToUpper() != "" || Cliente.Email.ToUpper() != ""
                   || Cliente.CEP.ToUpper() != "" || Cliente.Estados.ToUpper() != "")
                {    
                    _clienteDal.Inserir(Cliente);
                }
                else
                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                }
            }

            catch (Exception)
            {
                throw new Exception("VERIFIQUE OS DADOSA INSERIDOS.");
            }
        }

        public void Alterar(clsClienteDto Cliente)
        {
            _clienteDal = new clsClienteDal();
        try
        {
            if (Cliente.Telefone.ToUpper() != "" || Cliente.Empresa.ToUpper() != "" || Cliente.CNPJ.ToUpper() != "" || Cliente.Email.ToUpper() != ""
               || Cliente.CEP.ToUpper() != "" || Cliente.Estados.ToUpper() != "")
            {
                _clienteDal.Alterar(Cliente);
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

        public void Excluir(String Cliente)
        {
            clsClienteDal _ClienteDal = new clsClienteDal();
    
            try
            {
                if (Cliente == "")

                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                
                }
                else
                {
                    _ClienteDal.Excluir(Cliente);
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsClienteDto> ObterDados(int tipo, String filtro)
        {
            clsClienteDal _ClienteDal = new clsClienteDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _ClienteDal.obterDados(tipo, filtro);
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

        public List<clsClienteDto> obterDados(int tipo, String filtro)
        {
            try
            {
             clsClienteDal _ClienteDal = new clsClienteDal();

                if (tipo == 0 || tipo == 1)
                {
                    return _ClienteDal.obterDados(tipo, filtro);
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
