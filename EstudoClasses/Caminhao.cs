using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public sealed class Caminhao : Veiculo
    {
        public override string Abastecer()
        {
            return "O caminhão está abastecido";
        } 

        public override string Desligar()
        {
            return "O caminhão está desligado";
        }

        public override string Ligar()
        {
            return "O caminhão está desligado";
        }
    }
}
