using System;

namespace Prova
{
    public class Van : Veiculo, IManutencao
    {
        public bool PossuiRefrigeracao { get; }

        public Van(string identificacao, double capacidadeCarga, string tipoCombustivel, bool possuiRefrigeracao)
            : base(identificacao, capacidadeCarga, tipoCombustivel)
        {
            PossuiRefrigeracao = possuiRefrigeracao;
        }

        public override string RegistrarEntrega()
        {
            IncrementarQuantidadeEntregas();
            var refr = PossuiRefrigeracao ? "com refrigeração" : "sem refrigeração";
            return $"Van {Identificacao} ({refr}): entrega registrada.";
        }

        public string RealizarManutencao()
        {
            return $"Van {Identificacao}: revisão dos pneus realizada.";
        }
    }
}
