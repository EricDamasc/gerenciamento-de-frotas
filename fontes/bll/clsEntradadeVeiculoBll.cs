using dal;
using dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsEntradadeVeiculoBll
    {
        private clsEntradadeVeiculoDal _entrada;

        /* Método construtor (Fundamentos POO) */
        public clsEntradadeVeiculoBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _entrada = new clsEntradadeVeiculoDal();
        }

        public void Inserir(clsEntradadeVeiculoDto _entradaDto)
        {
            try
            {
                if (_entradaDto.Saida.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _entrada.Inserir(_entradaDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsEntradadeVeiculoDto entradaDto)
        {
            try
            {
                if (entradaDto.Saida.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _entrada.Alterar(entradaDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int entrada)
        {
            try
            {
                if (entrada <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _entrada.Excluir(entrada);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsEntradadeVeiculoDto> ObterDados(int tipo, String filtro)
        {
            clsEntradadeVeiculoDal _EntradaDAL = new clsEntradadeVeiculoDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _EntradaDAL.obterDados(tipo, filtro);
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

        public List<clsEntradadeVeiculoDto> obterDados(int tipo, String filtro)
        {
            clsEntradadeVeiculoDal _EntradaDAL = new clsEntradadeVeiculoDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _EntradaDAL.obterDados(tipo, filtro);
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

        public DataTable Obterdados(int tipo, String filtro)
        {
            return _entrada.ObterDadosGRID(tipo, filtro);
        }

        public DataTable ObterdadosNOVO(int tipo, String filtro)
        {
            return _entrada.ObterDadosNOVO(tipo, filtro);
        }
    }
}
