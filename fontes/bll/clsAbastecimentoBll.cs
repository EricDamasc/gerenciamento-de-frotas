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
    public class clsAbastecimentoBll
    {
        private clsAbastecimentoDal _abastecimento;

        /* Método construtor (Fundamentos POO) */

        public clsAbastecimentoBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _abastecimento = new clsAbastecimentoDal();
        }

        public void Inserir(clsAbastecimentoDto abastecimentoDto)
        {
            try
            {
                if (abastecimentoDto.Abastecimento.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _abastecimento.Inserir(abastecimentoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsAbastecimentoDto abastecimentoDto)
        {
            try
            {
                if (abastecimentoDto.Abastecimento.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _abastecimento.Alterar(abastecimentoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int abastecimentoDto)
        {
            try
            {
                if (abastecimentoDto <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _abastecimento.Excluir(abastecimentoDto);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsAbastecimentoDto> ObterDados(int tipo, String filtro)
        {
            clsAbastecimentoDal _abastecimentoDal = new clsAbastecimentoDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _abastecimentoDal.obterDados(tipo, filtro);
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

        public List<clsAbastecimentoDto> obterDados(int tipo, String filtro)
        {
            clsAbastecimentoDal _abastecimentoal = new clsAbastecimentoDal();
          
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _abastecimentoal.obterDados(tipo, filtro);
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
