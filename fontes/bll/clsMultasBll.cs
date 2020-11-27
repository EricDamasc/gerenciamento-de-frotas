using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using dal;
using dto;

namespace bll
{
    public class clsMultasBll
    {
        private clsMultasDal _multas;

        /* Método construtor (Fundamentos POO) */

        public clsMultasBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _multas = new clsMultasDal();
        }

        public void Inserir(clsMultasDto multasDto)
        {
            try
            {
                if (multasDto.idinfracao.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _multas.Inserir(multasDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsMultasDto multasdto)
        {
            try
            {
                if (multasdto.idinfracao.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _multas.Alterar(multasdto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int idinfracao)
        {
            try
            {

                if (idinfracao > 0)
                {
                    _multas.Excluir(idinfracao);
                }
                else
                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsMultasDto> ObterDados(int tipo, String filtro)
        {
            clsMultasDal _multasDal = new clsMultasDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _multasDal.obterDados(tipo, filtro);
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

        public List<clsMotoristasDto> ObterDados2(int tipo, String filtro)
        {
            clsMotoristasDal _motoristaDal = new clsMotoristasDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _motoristaDal.obterDados(tipo, filtro);
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

        public List<clsMultasDto> obterDados(int tipo, String filtro)
        {
            clsMultasDal _multasDal = new clsMultasDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _multasDal.obterDados(tipo, filtro);
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
