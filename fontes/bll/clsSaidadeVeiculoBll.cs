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
    public class clsSaidadeVeiculoBll
    {
        private clsSaidadeVeiculoDal _saida;

        /* Método construtor (Fundamentos POO) */
        public clsSaidadeVeiculoBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _saida = new clsSaidadeVeiculoDal();
        }

        public void Inserir(clsSaidadeVeiculoDto saidaDto)
        {
            try
            {
                if (saidaDto.Saida.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _saida.Inserir(saidaDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsSaidadeVeiculoDto saidaDto)
        {
            try
            {
                if (saidaDto.Saida.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _saida.Alterar(saidaDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int saida)
        {
            try
            {
                if (saida <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _saida.Excluir(saida);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsSaidadeVeiculoDto> ObterDados(int tipo, String filtro)
        {
            clsSaidadeVeiculoDal _SaidaeEntradaDAL = new clsSaidadeVeiculoDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _SaidaeEntradaDAL.obterdadosaida(tipo, filtro);
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

        public List<clsSaidadeVeiculoDto> obterdadosaida(int tipo, String filtro)
        {
            clsSaidadeVeiculoDal _SaidaeEntradaDAL = new clsSaidadeVeiculoDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _SaidaeEntradaDAL.obterdadosaida(tipo, filtro);
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
