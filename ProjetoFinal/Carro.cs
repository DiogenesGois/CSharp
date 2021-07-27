using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal {
    public class Carro {

        public decimal Id;
        public decimal IdMarca;
        private string CodigoMarca;
        private string CodigoModelo;
        private string Marca;
        private string Modelo;

        public string CodigoMarca1 { get => CodigoMarca; set => CodigoMarca = value; }
        public string CodigoModelo1 { get => CodigoModelo; set => CodigoModelo = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
    }
}
