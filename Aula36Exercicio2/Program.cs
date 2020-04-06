using System;

/*
 2) Numa determinada região, o imposto sobre propriedade é calculado a partir de duas informações:

área total do terreno (m2).
área construída do terreno (m2).
O imposto é cobrado da seguinte maneira:

R$ 5,00 para cada metro quadrado construído.
R$ 3,80 para cada metro quadrado não construído.  
  
 */

namespace Aula36Exercicio2
{
    class Program
    {
        public double areaTerreno = 0;
        public double areaConstruida = 0;
        public double total = 0;
        static void Main(string[] args)
        {
            (new Program()).CalculoTerreno();
        }

        public void CalculoTerreno()
        {
            Console.Write("Digite a area do terreno: ");
            areaTerreno = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a area construida: ");
            areaConstruida = Convert.ToDouble(Console.ReadLine());
            areaTerreno = (areaTerreno - areaConstruida) * 3.8;
            areaConstruida *= 5;
            total = areaConstruida + areaTerreno;

            Console.WriteLine("O valor da area construida {0}\n" +
                              "O valor da area não construida {1}\n" +
                              "O valor total {2}",
                              areaConstruida,
                              areaTerreno,
                              total);

        }
    }
}
