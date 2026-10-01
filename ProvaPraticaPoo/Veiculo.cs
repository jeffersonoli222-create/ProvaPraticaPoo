using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    public abstract class Veiculo
    {
        public string Identificacao { get; }
        public double CapacidadeCarga { get; }
        public string TipoCombustivel { get; }
        public int QuantidadeEntregas { get; private set; }

        protected Veiculo(string identificacao, double capacidadeCarga, string tipoCombustivel)
        {
            Identificacao = identificacao;
            CapacidadeCarga = capacidadeCarga;
            TipoCombustivel = tipoCombustivel;
            QuantidadeEntregas = 0;
        }

        protected void IncrementarQuantidadeEntregas()
        {
            QuantidadeEntregas++;
        }

        public abstract string RegistrarEntrega();
    }


}
