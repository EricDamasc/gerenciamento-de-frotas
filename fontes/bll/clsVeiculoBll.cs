using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using dal;
using dto;

namespace bll
{
    public class clsVeiculoBll
    {
        clsVeiculoDal _veiculoDal;

        public void Inserir(clsVeiculoDto Veiculo)
        {
            clsVeiculoDal _veiculoDal = new clsVeiculoDal();
            try
            {
                if (Veiculo.Placa.ToUpper() != "" || Veiculo.Marca.ToUpper() != "" || Veiculo.Ano <= DateTime.Now.Year
                    || Veiculo.Modelo.ToUpper() != "" || Veiculo.Consumo.ToUpper() != "" || Veiculo.Tipo.ToUpper() != "" || Veiculo.Disponibilidade.ToUpper() != "")
                {
                    _veiculoDal.Inserir(Veiculo);
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

        public void Alterar(clsVeiculoDto Veiculo)
        {
            clsVeiculoDal _veiculoDal = new clsVeiculoDal();
            try
            {
                if (Veiculo.Marca.ToUpper() != "" || Veiculo.Ano <= DateTime.Now.Year
                    || Veiculo.Modelo.ToUpper() != "" || Veiculo.Consumo.ToUpper() != "" || Veiculo.Tipo.ToUpper() != "" || Veiculo.Disponibilidade.ToUpper() != "")
                {

                    _veiculoDal.Alterar(Veiculo);
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

        public void Excluir(String Placa)
        {
            _veiculoDal = new clsVeiculoDal();

            try
            {
                if (Placa != "")
                {
                    _veiculoDal.Excluir(Placa);
                }
                else
                {
                    throw new Exception("PREENCHIMENTO INCORRETO");
                }
            }

            catch (Exception)
            {
                throw new Exception("VERIFIQUE SE O VEICULO NÃO POSSUI PENDÊNCIAS!");
            }
        }

        public List<clsVeiculoDto> ObterDados(int tipo, String filtro)
        {

            try
            {
                clsVeiculoDal _veiculoDal = new clsVeiculoDal();

                if ((tipo == 0) || (tipo == 1))
                {
                    return _veiculoDal.obterDados(tipo, filtro);
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

        public List<clsVeiculoDto> obterDados(int tipo, String filtro)
        {
            try
            {
                clsVeiculoDal _veiculoDal = new clsVeiculoDal();

                if (tipo == 0 || tipo == 1)
                {
                    return _veiculoDal.obterDados(tipo, filtro);
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


