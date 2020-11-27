using dto;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsPecaBll
    {
        clsPecasDal _pecaDal;

        public void Inserir(clsPecasDto Peca)
        {
            _pecaDal = new clsPecasDal();
            try
            {
                if (Peca.Peca.ToString() != "" || Peca.Marca.ToUpper() != "" || Peca.Pecas.ToUpper() != "" || Peca.Valor.ToString() != "" || Peca.OBS.ToUpper() != "")

                {
                    _pecaDal.Inserir(Peca);
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

        public void Alterar(clsPecasDto Peca)
        {
            _pecaDal = new clsPecasDal();
            try
            {
                if (Peca.Marca.ToUpper() != "" || Peca.Pecas.ToUpper() != "" || Peca.Valor.ToString() != "" || Peca.OBS.ToUpper() != "")

                {
                    _pecaDal.Alterar(Peca);
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

        public void Excluir(int Peca)
        {
            _pecaDal = new clsPecasDal();

            try
            {
                if (Peca > 0)

                {
                    _pecaDal.Excluir(Peca);
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

        public List<clsPecasDto> ObterDados(int tipo, String filtro)
        {
            clsPecasDal _pecaDal = new clsPecasDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _pecaDal.obterDados(tipo, filtro);
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

        public List<clsPecasDto> obterDados(int tipo, String filtro)
        {
            clsPecasDal _pecaDal = new clsPecasDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _pecaDal.obterDados(tipo, filtro);
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
