using dal;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsLocacaoBll
    {
        clsLocacaoDal _locacaoDal;

        public void Inserir(clsLocacaoDto Locacao)
        {
            _locacaoDal = new clsLocacaoDal();
            try
            {
                if (Locacao.IdLocacao.ToString() != "" || Locacao.Placa.ToUpper() != "" || Locacao.Valorlocacao.ToString() != "" || Locacao.DatadeLocacao.ToString() != "")

                {
                    _locacaoDal.Inserir(Locacao);
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

        public void Alterar(clsLocacaoDto Locacao)
        {
            _locacaoDal = new clsLocacaoDal();
            try
            {
                if (Locacao.Placa.ToUpper() != "" || Locacao.Valorlocacao.ToString() != "" || Locacao.DatadeLocacao.ToString() != "")

                {
                    _locacaoDal.Alterar(Locacao);
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

        public void Excluir(int IdLocacao)
        {
            _locacaoDal = new clsLocacaoDal();

            try
            {
                if (IdLocacao <= 0)

                {
                    _locacaoDal.Excluir(IdLocacao);
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

        public List<clsLocacaoDto> ObterDados(int tipo, String filtro)
        {
            clsLocacaoDal _locacaoDal = new clsLocacaoDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _locacaoDal.obterDados(tipo, filtro);
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

        public List<clsLocacaoDto> obterDados(int tipo, String filtro)
        {
            clsLocacaoDal _locacaoDal = new clsLocacaoDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _locacaoDal.obterDados(tipo, filtro);
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
