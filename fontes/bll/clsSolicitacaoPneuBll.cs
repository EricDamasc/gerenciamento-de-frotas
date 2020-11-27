using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using dal;
using dto;

namespace bll
{
    public class clsSolicitacaoPneuBll
    {
        private clsSolicitacaoPneuDal _solicitacao;

        /* Método construtor (Fundamentos POO) */
        public clsSolicitacaoPneuBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _solicitacao = new clsSolicitacaoPneuDal();
        }

        public void Inserir(clsSolicitacaoPneuDto solicitacaoDto)
        {
            try
            {
                if (solicitacaoDto.CodigoSolicitacao.ToString() == String.Empty)
                {
                    throw new Exception("O campo Codigo é obrigatório!");
                }

                _solicitacao.Inserir(solicitacaoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsSolicitacaoPneuDto solicitacaoDto)
        {
            try
            {
                if (solicitacaoDto.CodigoSolicitacao.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _solicitacao.Alterar(solicitacaoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int solicitacao)
        {
            try
            {
                if (solicitacao <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _solicitacao.Excluir(solicitacao);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }
    }
}
