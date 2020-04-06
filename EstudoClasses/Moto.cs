using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public sealed class Moto : Veiculo
    {
        public double CapacidadeTanque { get; set; }

        public override string Abastecer()
        {
            return "A moto está abastecida";
        }
        
        public override string Desligar()
        {
            return "A moto está desligada";
        }

        public override string Ligar()
        {
            return "A moto está ligada";
        }
    }
}
