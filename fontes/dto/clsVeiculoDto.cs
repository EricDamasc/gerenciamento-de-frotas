using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class clsVeiculoDto
    {

        private String _placa;
        private int _ano;
        private String _marca;
        private String _modelo;
        private String _consumo;
        private String _tipo;
        private String _disponibilidade;

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value;} 
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Consumo
        {
            get { return _consumo; }
            set { _consumo = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Disponibilidade
        {
            get { return _disponibilidade; }
            set { _disponibilidade = value; }
        }
    }
}
