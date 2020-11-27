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
    public class clsMotoristasBll
    {
        clsMotoristasDal _motoristaDal;

        public void Inserir(clsMotoristasDto Motoristas)
        {
            _motoristaDal = new clsMotoristasDal();
            try
            {
                if (Motoristas.CPF.ToUpper() != "" || Motoristas.RG.ToUpper() != "" || Motoristas.Nome.ToUpper() != ""
                    || Motoristas.Nascimento.ToUpper() != "" || Motoristas.NumCNH.ToUpper() != "" || Motoristas.TipoCNH.ToUpper() != "" || Motoristas.ValidadeCNH.ToString() != "")
                {
                    _motoristaDal.Inserir(Motoristas);
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

        public void Alterar(clsMotoristasDto Motoristas)
        {
            _motoristaDal = new clsMotoristasDal();
            try
            {
                if (Motoristas.Nome.ToUpper() != "" || Motoristas.NumCNH.ToUpper() != "" || Motoristas.TipoCNH.ToUpper() != "" || Motoristas.ValidadeCNH.ToString() != "")
                {
                    _motoristaDal.Alterar(Motoristas);
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

        public void Excluir(int IdMotorista)
        {
            _motoristaDal = new clsMotoristasDal();
            try
            {
                if (IdMotorista > 0)
                {
                    _motoristaDal.Excluir(IdMotorista);
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

        public List<clsMotoristasDto> ObterDados(int tipo, String filtro)
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

        public List<clsMotoristasDto> obterDados(int tipo, String filtro)
        {
            try
            {
                clsMotoristasDal _motoristasDal = new clsMotoristasDal();

                if (tipo == 0 || tipo == 1)
                {
                    return _motoristasDal.obterDados(tipo, filtro);
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
