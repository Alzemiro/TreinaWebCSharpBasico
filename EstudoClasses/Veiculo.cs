using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public abstract class Veiculo : IVeiculo
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Potencia { get; set; }

        public abstract string Ligar();
        public abstract string Desligar();   
        public abstract string Abastecer();
        public string Desabaster()
        {
            return "O veículo está desabastecido";
            
        }
    }
}
