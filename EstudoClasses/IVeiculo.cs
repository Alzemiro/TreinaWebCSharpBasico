using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public interface IVeiculo
    {
        string Ligar();
        string Desligar();
        string Abastecer();
        string Desabaster();
    }
}
