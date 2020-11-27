using dto;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace bll
{
    public class clsPneusBll
    {
        clsPneusDal _pneus;

        public void Inserir(clsPneusDto pneuDto)
        {
            _pneus = new clsPneusDal();

            try
            {
                if (pneuDto.Pneu.ToString() == String.Empty)
                {
                    throw new Exception("O campo Codigo é obrigatório!");
                }

                _pneus.Inserir(pneuDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsPneusDto pneuDto)
        {
            try
            {
                _pneus = new clsPneusDal();

                if (pneuDto.Observacao.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _pneus.Alterar(pneuDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int pneu)
        {
            try
            {
                _pneus = new clsPneusDal();

                if (pneu <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _pneus.Excluir(pneu);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsPneusDto> ObterDados(int tipo, String filtro)
        {
            clsPneusDal _pneuDal = new clsPneusDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _pneuDal.obterDados(tipo, filtro);
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

        public List<clsPneusDto> obterDados(int tipo, String filtro)
        {
            try
            {
                clsPneusDal _pneuDal = new clsPneusDal();

                if (tipo == 0 || tipo == 1)
                {
                    return _pneuDal.obterDados(tipo, filtro);
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
