using dal;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class clsAdicionarManutencaBll
    {
        clsAdicionarManutencaoDal _manutencaoDal;

        public void Inserir(clsAdicionarManutencaoDto Manutencao)
        {
            _manutencaoDal = new clsAdicionarManutencaoDal();
            try
            {
                if (Manutencao.ODS.ToString() != "" || Manutencao.idPeca.ToString() != "" || Manutencao.Placa.ToString() != "" || Manutencao.Problemas.ToUpper() != "" || Manutencao.DatadeManu.ToString() != "" || Manutencao.TipoManutencao.ToUpper() != "")

                {
                    _manutencaoDal.Inserir(Manutencao);
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

        public void Alterar(clsAdicionarManutencaoDto Manutencao)
        {
            _manutencaoDal = new clsAdicionarManutencaoDal();
            try
            {
                if (Manutencao.idPeca.ToString() != "" || Manutencao.Placa.ToString() != "" || Manutencao.Problemas.ToUpper() != "" || Manutencao.DatadeManu.ToString() != "" || Manutencao.TipoManutencao.ToUpper() != "")

                {
                    _manutencaoDal.Alterar(Manutencao);
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

        public void Excluir(int Manutencao)
        {
            _manutencaoDal = new clsAdicionarManutencaoDal();

            try
            {
                if (Manutencao <= 0)

                {
                    _manutencaoDal.Excluir(Manutencao);
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

        public List<clsAdicionarManutencaoDto> ObterDados(int tipo, String filtro)
        {
            clsAdicionarManutencaoDal _manutencaoDal = new clsAdicionarManutencaoDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _manutencaoDal.obterDados(tipo, filtro);
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

        public List<clsAdicionarManutencaoDto> obterDados(int tipo, String filtro)
        {
            clsAdicionarManutencaoDal _manutencaoDal = new clsAdicionarManutencaoDal();
            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _manutencaoDal.obterDados(tipo, filtro);
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
