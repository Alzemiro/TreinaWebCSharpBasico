using System;


/*
 1) Uma parede em formato retangular, cuja altura é hp (altura da parede) e a largura lp (largura da parede) 
 precisa ser coberta por azulejos também retangulares. 
 O azulejo retangular tem dimensões ha (altura do azulejo) e la (largura do azulejo).

Escreva um programa que leia as quatro medidas hp, lp, ha e la, 
calcule e imprima quantos azulejos com as medidas dadas são necessários para cobrir a parede dada.
 
 */



namespace Aula36Exercicio1
{
    class Program
    {
        public int hp = 0;
        public int lp = 0;
        public int ha = 0;
        public int la = 0;
        public int azulejos = 0;
        static void Main(string[] args)
        {
            (new Program()).Calculo();     
        }

        public void Calculo()
        {
            Console.Write("Digite a largura da parede: ");
            hp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura da parede: ");
            lp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a largura do azulejo: ");
            ha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do azulejo: ");
            la = Convert.ToInt32(Console.ReadLine());

            hp *= lp;
            ha *= la;
            azulejos = hp / lp;
            
            Console.WriteLine("A area da parede mede: {0} \n" +
                              "O area do azulejo mede: {1} \n" +
                              "Serão necessários {2} para cobrir a parede", 
                              hp,
                              ha,
                              azulejos);

        }
        
    }
}
