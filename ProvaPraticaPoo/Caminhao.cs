using System;

namespace Prova
{
    public class Caminhao : Veiculo, IManutencao
    {
        public int NumerosEixos { get; }

        public Caminhao(string identificacao, double capacidadeCarga, string tipoCombustivel, int numerosEixos)
            : base(identificacao, capacidadeCarga, tipoCombustivel)
        {
            NumerosEixos = numerosEixos;
        }

        public override string RegistrarEntrega()
        {
            IncrementarQuantidadeEntregas();
            return $"Caminhão {Identificacao} com {NumerosEixos} eixos: entrega registrada.";
        }

        public string RealizarManutencao()
        {
            return $"Caminhão {Identificacao}: revisão dos freios realizada.";
        }
    }
}
